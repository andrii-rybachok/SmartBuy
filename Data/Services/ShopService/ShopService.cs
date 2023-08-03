using AutoMapper;
using Duende.IdentityServer.Extensions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Filters.Value;
using SmartBuyApi.Data.Models.DTO.GlobalCategory;
using SmartBuyApi.Data.Models.DTO.Product;
using SmartBuyApi.DataBase;
using System.Reflection;
using System.Text.RegularExpressions;

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

		public async Task<List<GlobalCategoryShowDTO>> GetGlobalCategories()
		{
			var glCategories = await _context.GlobalCategories.Include(x=>x.Categories).ThenInclude(x=>x.Image).Where(x=>x.Categories.Count>0).ToListAsync();
			return _mapper.Map<List<GlobalCategoryEntity>, List<GlobalCategoryShowDTO>>(glCategories);
		}

		public async Task<CategoryShowDTO> GetCategoryById(string id)
		{
			var category = await _context.Categories
				.Include(x => x.Products)
				.Include(x => x.FilterNames)
				.ThenInclude(x => x.Values)
				.FirstOrDefaultAsync(x => x.Id == id);
			if (category != null)
			{
				CategoryShowDTO categoryShow = _mapper.Map<CategoryEntity, CategoryShowDTO>(category);
				FilterNameShowDTO filterPrice = new FilterNameShowDTO() { Name = "Price", PublicName = "Ціна" };
				var priceLimit = await GetMinAndMaxPrice(categoryShow.Products);
				FilterValueShowDTO filterValuePrice = new FilterValueShowDTO() { PublicValue = "", MinValue = priceLimit.Min, MaxValue = priceLimit.Max, StringValue = "" };
				filterPrice.Values.Add(filterValuePrice);
				categoryShow.Filters.Add(filterPrice);
				return categoryShow;
			}
			return null;
		}


		public async Task<CategoryShowDTO> GetCategoryByFilters(List<FilterNameGetDTO> filters, string categoryId)
		{
			List<ProductEntity> products = new List<ProductEntity>();
			var basic_category = await _context.Categories.Include(x => x.Products)
				.Include(x => x.FilterNames)
				.ThenInclude(x => x.Values)
				.FirstAsync(x => x.Id == categoryId);
			var category = _mapper.Map<CategoryEntity, CategoryShowDTO>(basic_category);

			products = GetProductsByFilters(basic_category.Products, filters);


			category.Filters = GetMatchedFilters(category.Filters, filters, products);

			category.Products = _mapper.Map<List<ProductEntity>, List<ProductShowDTO>>(products);
			FilterNameShowDTO filterPrice = new FilterNameShowDTO() { Name = "Price", PublicName = "Ціна" };
			var priceLimit = await GetMinAndMaxPrice(category.Products);
			FilterValueShowDTO filterValuePrice = new FilterValueShowDTO() { PublicValue = "", MinValue = priceLimit.Min, MaxValue = priceLimit.Max, StringValue = "" };
			filterPrice.Values.Add(filterValuePrice);
			category.Filters.Add(filterPrice);
			return category;
		}

		public async Task<List<ProductEntity>> FilterProductsForSearch(List<ProductEntity> products, List<FilterNameGetDTO> filters)
		{
			if (filters != null && filters.Count > 0)
			{
				products = GetProductsByFilters(products, filters);
			}
			return products;
		}

		public async Task<List<FilterNameShowDTO>> GetAvailableSearchFilters(List<ProductEntity> products, List<FilterNameGetDTO> active_filters, string? categoryId,string searchText)
		{
			List<FilterNameShowDTO> basic_filters = new List<FilterNameShowDTO>();
			if (!categoryId.IsNullOrEmpty())
			{
				basic_filters = _mapper.Map<List<FilterNameShowDTO>>((await _context.Categories.Include(x => x.FilterNames)
					.ThenInclude(x => x.Values)
					.FirstOrDefaultAsync(x => x.Id == categoryId))
					.FilterNames);
			}

			basic_filters.AddRange(await GetBasicFiltersForSearch(_mapper.Map<List<ProductSearchDTO>>(products)));


			List<FilterNameShowDTO> remainFilters = basic_filters.ToList();
			string firstFilterName = "";
			var categoryFilter = active_filters.FirstOrDefault(x => x.Name == "Category");
			if (categoryFilter != null)
			{
				active_filters.Remove(categoryFilter);
			}

			List<ProductEntity> variableProducts = products;
			List<ProductEntity> productsFromSearch=await GetProductsBySearch(searchText);

			if (active_filters != null && active_filters.Count > 0)
			{
				firstFilterName = active_filters.ElementAt(0).Name;
			}
			foreach (var filter in remainFilters)
			{
				if (filter.Name!="Category")
				{
					if(firstFilterName == filter.Name)
					{
						variableProducts = productsFromSearch;
					}
					foreach (var value in filter.Values.ToList())
					{
						if (!IsProductsMatchValue(value, variableProducts, filter.Name))
						{
							basic_filters.First(x => x.Id == filter.Id).Values.Remove(value);
							filter.Values.Remove(value);
						}
					}
					if (filter.Values.Count == 0)
					{
						basic_filters.Remove(filter);
					}
				}
				variableProducts = products;
			}
			return basic_filters;
		}


		public async Task<List<CategorySearchDTO>> GetCategoriesFromProducts(List<ProductSearchDTO> products)
		{
			List<CategorySearchDTO> categories = new List<CategorySearchDTO>();
			await Task.Run(() =>
			{
				foreach (var product in products)
				{
					if (!categories.Contains(product.Category))
					{
						categories.Add(product.Category);
					}
				}
			});
			return categories;
		}

		public async Task<List<FilterNameShowDTO>> GetBasicFiltersForSearch(List<ProductSearchDTO> products)
		{
			List<FilterNameShowDTO> filters = new List<FilterNameShowDTO>();
			FilterNameShowDTO filterCategory = new FilterNameShowDTO() { Name = "Category", PublicName = "Категорії" };
			products = products.DistinctBy(x => x.Category.Name).ToList();
			foreach (var product in products)
			{
				FilterValueShowDTO value = new FilterValueShowDTO() { MaxValue = 0, MinValue = 0, PublicValue = product.Category.Name, StringValue = product.Category.Id };
				filterCategory.Values.Add(value);
			}
			FilterNameShowDTO filterPrice = new FilterNameShowDTO() { Name = "Price", PublicName = "Ціна" };

			var priceLimits = await GetMinAndMaxPrice(new List<ProductShowDTO>(products));
			FilterValueShowDTO priceValue = new FilterValueShowDTO() { MaxValue = priceLimits.Max, MinValue = priceLimits.Min, PublicValue = "", StringValue = "" };
			filterPrice.Values.Add(priceValue);
			filters.AddRange(new FilterNameShowDTO[] { filterCategory, filterPrice });
			return filters;
		}

		public async Task<List<ProductEntity?>> GetProductsBySearch(string searchText)
		{
			string pattern = searchText;
			try
			{
				var products = await _context.Products
				.Include(x => x.Category)
				.ToListAsync();
				var filteredProducts = products.Where(x =>
				{
					var res = Regex.Match(x.Name, pattern, RegexOptions.IgnoreCase).Success;
					return res;
				}).ToList();
				if (filteredProducts.Count() > 0)
				{
					return filteredProducts;
				}
			}
			catch (Exception ex)
			{

			}
			return null;
		}

		public async Task<string?> GetCategoryBySearch(string categoryName)
		{
			var category = await _context.Categories
			.FirstOrDefaultAsync(x => x.Name == categoryName);
			if (category != null)
			{
				return category.Id;
			}
			return null;
		}
		public async Task<(int Min, int Max)> GetMinAndMaxPrice(List<ProductShowDTO> products)
		{

			int min = 0, max = 0;
			if (products.Count > 0)
			{
				await Task.Run(() =>
				{
					min = products.Min(x => x.Price);
					max = products.Max(x => x.Price);
				});
			}
			return (min, max);
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
			if (obj != null)
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
		List<ProductEntity> GetProductsByFilters(List<ProductEntity> base_products, List<FilterNameGetDTO> filters)
		{
			List<ProductEntity> res_products = new List<ProductEntity>();
			var filteredProducts = GetProductsByFilter(filters.ElementAt(0), base_products);

			res_products.AddRange(filteredProducts);
			for (int i = 1; i < filters.Count; i++)
			{
				filteredProducts = GetProductsByFilter(filters.ElementAt(i), res_products);
				res_products = filteredProducts;
			}
			return res_products;
		}

		List<FilterNameShowDTO> GetMatchedFilters(List<FilterNameShowDTO> basic_filters, List<FilterNameGetDTO?> active_filters, List<ProductEntity> products)
		{

			List<FilterNameShowDTO> remainFilters = basic_filters.ToList();
			string firstFilterName = "";

			if (active_filters != null && active_filters.Count > 0)
			{
				firstFilterName = active_filters.ElementAt(0).Name;
			}
			foreach (var filter in remainFilters)
			{
				if (firstFilterName != filter.Name)
				{
					foreach (var value in filter.Values.ToList())
					{
						if (!IsProductsMatchValue(value, products, filter.Name))
						{
							basic_filters.First(x => x.Id == filter.Id).Values.Remove(value);
							filter.Values.Remove(value);
						}
					}
					if (filter.Values.Count == 0)
					{
						basic_filters.Remove(filter);
					}
				}
			}
			return basic_filters;
		}
		List<ProductEntity> GetProductsByFilter(FilterNameGetDTO filter, List<ProductEntity> initialProducts)
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
					filteredProducts = initialProducts.Where(product => filterValue.StringValue == GetPropertyValue(product, filter.Name)).ToList();
				}
				products.AddRange(filteredProducts);
			}
			return products;
		}
	}
}
