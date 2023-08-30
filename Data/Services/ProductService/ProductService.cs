using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO;
using SmartBuyApi.Data.Models.DTO.Image;
using SmartBuyApi.Data.Models.DTO.Product;
using SmartBuyApi.Data.Services.ShopService;
using SmartBuyApi.Data.Services.UserService;
using SmartBuyApi.DataBase;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SmartBuyApi.Data.Services.ProductService
{
	public class ProductService : IProductService
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;
		private readonly IFilterService _filterService;
		public ProductService(ApplicationDbContext context, IMapper mapper, IFilterService filterService)
		{
			_context = context;
			_mapper = mapper;
			_filterService = filterService;
		}

		public async Task<List<ProductShowDTO>> GetLastSeenProducts(string[] productIds)
		{
			var products=new List<ProductShowDTO>();
			foreach (var id in productIds)
			{
				var product = _context.Products.FirstOrDefaultAsync(x => x.Id == id);
				if (product != null)
				{
					products.Add(_mapper.Map<ProductShowDTO>(product));
				}
			}
			return products;
		}
        
        public List<ProductShowDTO> GetPromotedProducts()
		{
			var products= _context.Products.Include(x=>x.Reviews).Include(x=>x.Images).Where(x=>x.Dicount>1).Take(10).ToList();
			if (products.Count > 0)
			{
				return _mapper.Map<List<ProductShowDTO>>(products);
			}
			products = _context.Products.Include(x => x.Reviews).Include(x => x.Images).Take(10).ToList();
			return _mapper.Map<List<ProductShowDTO>>(products);
		}
		
		public async Task<ProductDetailDTO> GetProductByIdAsync(string id)
		{
			var product=await _context.Products.Include(x=>x.Images)
				.Include(x=>x.Category)
				.ThenInclude(x=>x.FilterNames)
				.ThenInclude(x=>x.Values)
				.FirstOrDefaultAsync(x=>x.Id == id);

			return mapProduct(product);
		}

		public ProductEntity LikeProduct(string userId, string productId)
		{
			var user = _context.Users.FirstOrDefault(x => x.Id == userId);
			var product=_context.Products.FirstOrDefault(x=>x.Id == productId);
			if (product != null)
			{
				product.UserLikeId = user.Id;
				_context.Update(product);
				_context.SaveChanges();
			}
			return product;
		}
		
		ProductDetailDTO mapProduct(ProductEntity product)
		{
			ProductDetailDTO _product = new ProductDetailDTO();
			_product.Id = product.Id;
			_product.Name = product.Name;
			_product.Description = product.Description;
			_product.Images = _mapper.Map<List<ImageShowDTO>>(product.Images);
			_product.Reviews=product.Reviews.ToList();
			_product.Price= product.Price;
			var filters = product.Category.FilterNames;
			List<Characteristic> characteristics = new List<Characteristic>();
			foreach (var filter in filters)
			{
				Characteristic characteristic = new Characteristic();
				characteristic.Name = filter.PublicName;
				var value = GetPropertyValue(product, filter.Name);
				if (filter.Values.ElementAt(0).IsNumeric())
				{
					characteristic.Value= value +" "+ filter.Metric;
				}
				else
				{
					characteristic.Value = filter.Values.FirstOrDefault(x => x.StringValue == value).PublicValue;
				}
				characteristics.Add(characteristic);
			}
			_product.Characteristics = characteristics;
			return _product;
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
	}
}
