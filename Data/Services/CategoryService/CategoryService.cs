using AutoMapper;
using Azure;
using Microsoft.EntityFrameworkCore;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Filters.Value;
using SmartBuyApi.Data.Models.DTO.GlobalCategory;
using SmartBuyApi.Data.Models.DTO.Product;
using SmartBuyApi.Data.Models.Responses;
using SmartBuyApi.Data.Services.ShopService;
using SmartBuyApi.DataBase;

namespace SmartBuyApi.Data.Services.CategoryService
{
	public class CategoryService:ICategoryService
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;
		private readonly IFilterService _filterService;

		public CategoryService(ApplicationDbContext context, IMapper mapper, IFilterService filterService)
		{
			_context = context;
			_mapper = mapper;
			_filterService = filterService;
		}
		public async Task<List<GlobalCategoryShowDTO>> GetGlobalCategories()
		{
			var glCategories = await _context.GlobalCategories.
				Include(x => x.Categories)
				.ThenInclude(x => x.Image)
				.Where(x => x.Categories.Count > 0).ToListAsync();
			return _mapper.Map<List<GlobalCategoryEntity>, List<GlobalCategoryShowDTO>>(glCategories);
		}
		public async Task<GlobalCategoryResponse> GetGlobalCategoryCatalogAsync(string id)
		{
			GlobalCategoryResponse response =new GlobalCategoryResponse();
			var globalCategory = await GetGlobalCategoryById(id);

            if (globalCategory != null)
			{
				response.GlobalCategory= _mapper.Map<GlobalCategoryEntity, GlobalCategoryShowDTO>(globalCategory);
				var responseProducts = GetGlobalCategoryProducts(globalCategory);
                response.Products = _mapper.Map<List<ProductEntity>, List<ProductShowDTO>>(responseProducts);
				response.Filters =await _filterService.GetBasicFiltersAsync(response.Products);
				return response;
			}
			throw new Exception("Not found ");
		}
        public async Task<GlobalCategoryShowDTO> GetGlobalCategoryByCategoryIdAsync(string categoryId)
        {
            var globalCategory = await GetGlobalCategoryByCategoryId(categoryId);

            if (globalCategory != null)
            {
                var res = _mapper.Map<GlobalCategoryEntity, GlobalCategoryShowDTO>(globalCategory);
				return res;
            }
            throw new Exception("Not found ");
        }
        public async Task<CategoryShowDTO> GetCategoryById(string id)
		{
			var category =  await GetCategoryByIdAsync(id);
			if (category != null)
			{
				CategoryShowDTO categoryShow = _mapper.Map<CategoryEntity, CategoryShowDTO>(category);
				var basic_filters = await _filterService.GetBasicFiltersAsync(categoryShow.Products);
				categoryShow.Filters.AddRange(basic_filters);
				return categoryShow;
			}
			return null;
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
		public async Task<CategoryShowDTO> GetCategoryByFilters(List<FilterNameGetDTO> filters, string categoryId)
		{
			List<ProductEntity> products = new List<ProductEntity>();
			var basic_category = await GetCategoryByIdAsync(categoryId);
			var category = _mapper.Map<CategoryEntity, CategoryShowDTO>(basic_category);

			products = _filterService.GetProductsByFilters(basic_category.Products, filters);


			category.Filters = _filterService.GetMatchedFilters(category.Filters, filters, products);

			category.Products = _mapper.Map<List<ProductEntity>, List<ProductShowDTO>>(products);
			

			var basic_filters = await _filterService.GetBasicFiltersAsync(category.Products);

			category.Filters.AddRange(basic_filters);
			return category;
		}
        public async Task<GlobalCategoryResponse> GetGlobalCategoryResponseByFilters(List<FilterNameGetDTO> filters, string glCategoryId)
		{
            var catalog = await GetGlobalCategoryCatalogAsync(glCategoryId);
            var globalCategory = await GetGlobalCategoryById(glCategoryId);
			var productEntityList = GetGlobalCategoryProducts(globalCategory);
            productEntityList = _filterService.GetProductsByFilters(productEntityList, filters);
			catalog.Products = _mapper.Map<List<ProductShowDTO>>(productEntityList);
			return catalog;
        }
        private async Task<GlobalCategoryEntity> GetGlobalCategoryById(string id)
        {
            return await _context.GlobalCategories
                .Include(x => x.Categories).ThenInclude(x => x.Image)
                .Include(x => x.Categories).ThenInclude(x => x.Products).ThenInclude(x=>x.Images)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        private async Task<GlobalCategoryEntity> GetGlobalCategoryByCategoryId(string id)
        {
			var category = await _context.Categories
				.Include(x => x.GlobalCategory)
				.ThenInclude(x => x.Image)
				.Include(x => x.GlobalCategory)
				.ThenInclude(x => x.Categories).ThenInclude(x => x.Image)
				.FirstOrDefaultAsync(x => x.Id == id);
			if(category != null)
			{
                return category.GlobalCategory;
			}
			return null;
        }
		private async Task<CategoryEntity> GetCategoryByIdAsync(string id)
		{
			return await _context.Categories.Include(x => x.Products)
                .Include(x => x.FilterNames)
                .ThenInclude(x => x.Values)
                .Include(x => x.Products).ThenInclude(x => x.Images)
                .FirstAsync(x => x.Id == id);
        }
        private List<ProductEntity> GetGlobalCategoryProducts(GlobalCategoryEntity globalCategory)
        {

            if (globalCategory != null)
            {
                var responseProducts = new List<ProductEntity>();
                foreach (var category in globalCategory.Categories)
                {
                    responseProducts.AddRange(category.Products);
                }
                return responseProducts;
            }
            return null;
        }
    }
}
