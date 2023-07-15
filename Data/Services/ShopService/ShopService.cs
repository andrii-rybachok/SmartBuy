using AutoMapper;
using Duende.IdentityServer.Extensions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Filters.Value;
using SmartBuyApi.Data.Models.DTO.Product;
using SmartBuyApi.DataBase;
using System.Reflection;

namespace SmartBuyApi.Data.Services.ShopService
{
	public class ShopService : IShopService
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;


		public ShopService(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<List<CategoryItemDTO>> GetAllCategories()
		{
			var categories = await _context.Categories.ToListAsync();
			return _mapper.Map<List<CategoryEntity>, List<CategoryItemDTO>>(categories);
		}

		public async Task<CategoryShowDTO> GetCategoryById(string id)
		{
			var category = await _context.Categories
				.Include(x => x.Products)
				.Include(x => x.FilterNames)
				.ThenInclude(x => x.Values)
				.FirstAsync(x => x.Id == id);
			CategoryShowDTO categoryShow = _mapper.Map<CategoryEntity, CategoryShowDTO>(category);
			return categoryShow;
		}

		

		public List<ProductEntity> GetProductByFilter(FilterNameGetDTO filter, List<ProductEntity> initialProducts)
		{

			var products = new List<ProductEntity>();
			foreach (var filterValue in filter.Values)
			{
				List<ProductEntity> filteredProducts = new List<ProductEntity>();
				if (filterValue.IsNumeric())
				{
					filteredProducts = initialProducts.Where(product => filterValue.IsInRange(GetPropertyValue(product, filter.Name))).ToList();
				}
				else
				{
					filteredProducts = initialProducts.Where(product => filterValue.StringValue== GetPropertyValue(product, filter.Name)).ToList();
				}
				products.AddRange(filteredProducts);
			}
			return products;
		}

		public CategoryShowDTO GetProductByFilters(List<FilterNameGetDTO> filters, string categoryId)
		{
			List<ProductEntity> products = new List<ProductEntity>();
			var basic_category = _context.Categories.Include(x => x.Products)
				.Include(x => x.FilterNames)
				.ThenInclude(x => x.Values)
				.First(x => x.Id == categoryId);
			var category = _mapper.Map<CategoryEntity, CategoryShowDTO>(basic_category);
			var filteredProducts = GetProductByFilter(filters.ElementAt(0), basic_category.Products);

			products.AddRange(filteredProducts);
			for (int i = 1; i < filters.Count; i++)
			{
				filteredProducts = GetProductByFilter(filters.ElementAt(i), products);
				products=filteredProducts;
			}



			List<FilterNameShowDTO> remainFilters = category.Filters.ToList();
		
			foreach (var filter in remainFilters.ToList())
			{
				if (filters.ElementAt(0).Name!=filter.Name)
				{
					foreach (var value in filter.Values.ToList())
					{
						if (!IsProductsMatchValue(value, products, filter.Name))
						{
							category.Filters.First(x => x.Id == filter.Id).Values.Remove(value);
							filter.Values.Remove(value);
						}
					}
					if (filter.Values.Count == 0)
					{
						category.Filters.Remove(filter);
					}
				}
			}
			category.Products = _mapper.Map<List<ProductEntity>, List<ProductShowDTO>>(products);
			return category;
		}

		string? GetPropertyValue(object srcobj, string propertyName)
		{
			if (srcobj == null)
				return null;

			object obj = srcobj;

			// Split property name to parts (propertyName could be hierarchical, like obj.subobj.subobj.property
			string[] propertyNameParts = propertyName.Split('.');

			foreach (string propertyNamePart in propertyNameParts)
			{
				if (obj == null) return null;

				// propertyNamePart could contain reference to specific 
				// element (by index) inside a collection
				if (!propertyNamePart.Contains("["))
				{
					PropertyInfo pi = obj.GetType().GetProperty(propertyNamePart);
					if (pi == null) return null;
					obj = pi.GetValue(obj, null);
				}
				else
				{   // propertyNamePart is areference to specific element 
					// (by index) inside a collection
					// like AggregatedCollection[123]
					//   get collection name and element index
					int indexStart = propertyNamePart.IndexOf("[") + 1;
					string collectionPropertyName = propertyNamePart.Substring(0, indexStart - 1);
					int collectionElementIndex = Int32.Parse(propertyNamePart.Substring(indexStart, propertyNamePart.Length - indexStart - 1));
					//   get collection object
					PropertyInfo pi = obj.GetType().GetProperty(collectionPropertyName);
					if (pi == null) return null;
					object unknownCollection = pi.GetValue(obj, null);
					//   try to process the collection as array
					if (unknownCollection.GetType().IsArray)
					{
						object[] collectionAsArray = unknownCollection as object[];
						obj = collectionAsArray[collectionElementIndex];
					}
					else
					{
						//   try to process the collection as IList
						System.Collections.IList collectionAsList = unknownCollection as System.Collections.IList;
						if (collectionAsList != null)
						{
							obj = collectionAsList[collectionElementIndex];
						}
						else
						{
							throw new Exception(" Unsupported collection type");
							// ??? Unsupported collection type
						}
					}
				}
			}
			if(obj!=null)
			return obj.ToString();
			return null;
		}
		bool IsProductsMatchValue(FilterValueShowDTO filterValue, List<ProductEntity> products, string filterName)
		{
			bool result = false;
			ProductEntity? first;
			if (filterValue.IsNumeric())
			{
				first = products.FirstOrDefault(product => filterValue.IsInRange(GetPropertyValue(product, filterName)));

			}
			else
			{
				first = products.FirstOrDefault(product => filterValue.StringValue == GetPropertyValue(product, filterName));

			}
			result = first != null ? true : false;
			return result;
		}
	}
}
