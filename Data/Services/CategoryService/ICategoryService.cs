using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.GlobalCategory;
using SmartBuyApi.Data.Models.DTO.Product;
using SmartBuyApi.Data.Models.Responses;

namespace SmartBuyApi.Data.Services.CategoryService
{
	public interface ICategoryService
	{
		Task<CategoryShowDTO> GetCategoryById(string id);
		Task<List<GlobalCategoryShowDTO>> GetGlobalCategories();

		Task<CategoryShowDTO> GetCategoryByFilters(List<FilterNameGetDTO> filters, string categoryId);
		Task<List<CategorySearchDTO>> GetCategoriesFromProducts(List<ProductSearchDTO> products);
		Task<string?> GetCategoryBySearch(string categoryName);
		Task<GlobalCategoryResponse> GetGlobalCategoryCatalogAsync(string id);
        Task<GlobalCategoryResponse> GetGlobalCategoryResponseByFilters(List<FilterNameGetDTO> filters, string glCategoryId);
		Task<GlobalCategoryShowDTO> GetGlobalCategoryByCategoryIdAsync(string id);

    }
}
