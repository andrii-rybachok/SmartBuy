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
using SmartBuyApi.Data.Services.ProductService;
using SmartBuyApi.DataBase;
using SmartBuyApi.Helpers;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SmartBuyApi.Data.Services.ShopService
{
	public class FilterService : IFilterService
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;


        public FilterService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public async Task<List<ProductEntity>> FilterProductsForSearch(List<ProductEntity> products, List<FilterNameGetDTO> filters)
		{
			if (filters != null && filters.Count > 0)
			{
				products = GetProductsByFilters(products, filters);
			}
			return products;
		}

		public async Task<List<FilterNameShowDTO>> GetBasicFiltersAsync(List<ProductShowDTO> products)
		{
            List<FilterNameShowDTO> filters = new List<FilterNameShowDTO>();
            FilterNameShowDTO filterPrice = new FilterNameShowDTO() { Name = "Price", PublicName = "Ціна" };
            var priceLimits = await GetMinAndMaxPrice(new List<ProductShowDTO>(products));
            FilterValueShowDTO priceValue = new FilterValueShowDTO() { MaxValue = priceLimits.Max, MinValue = priceLimits.Min, PublicValue = "", StringValue = "" };
            filterPrice.Values.Add(priceValue);
			filters.Add(filterPrice);
			return filters;
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
			List<ProductEntity> productsFromSearch=await GetProductsBySearchString(searchText);

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
			var basic_filters =await GetBasicFiltersAsync(_mapper.Map<List<ProductShowDTO>>(products));
            basic_filters.Add(filterCategory);
            filters.AddRange(basic_filters);
			return filters;
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
        public async Task<List<ProductEntity?>> GetProductsBySearchString(string searchText)
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
        public List<ProductEntity> GetProductsByFilters(List<ProductEntity> base_products, List<FilterNameGetDTO> filters)
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

		public List<FilterNameShowDTO> GetMatchedFilters(List<FilterNameShowDTO> basic_filters, List<FilterNameGetDTO?> active_filters, List<ProductEntity> products)
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
		
		bool IsProductsMatchValue(FilterValueShowDTO filterValue, List<ProductEntity> products, string filterName)
		{
			bool result = false;
			ProductEntity? first;
			if (filterValue.IsNumeric())
			{
				first = products.FirstOrDefault(product => filterValue.IsInRange(PropertyHelper.GetPropertyValue(product, filterName)));

			}
			else
			{
				first = products.FirstOrDefault(product => filterValue.StringValue == PropertyHelper.GetPropertyValue(product, filterName));

			}
			result = first != null ? true : false;
			return result;
		}
		
		List<ProductEntity> GetProductsByFilter(FilterNameGetDTO filter, List<ProductEntity> initialProducts)
		{

			var products = new List<ProductEntity>();
			foreach (var filterValue in filter.Values)
			{
				List<ProductEntity> filteredProducts = new List<ProductEntity>();
				if (filterValue.IsNumeric())
				{
					filteredProducts = initialProducts.Where(product => filterValue.IsInRange(PropertyHelper.GetPropertyValue(product, filter.Name))).ToList();
				}
				else
				{
					filteredProducts = initialProducts.Where(product => filterValue.StringValue == PropertyHelper.GetPropertyValue(product, filter.Name)).ToList();
				}
				products.AddRange(filteredProducts);
			}
			return products;
		}
	}
}
