using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.GlobalCategory;
using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Services.ShopService
{
	public interface IShopService
	{
		Task<CategoryShowDTO> GetCategoryById(string id);
		Task<List<GlobalCategoryShowDTO>> GetGlobalCategories();


		Task<CategoryShowDTO> GetCategoryByFilters(List<FilterNameGetDTO> filters, string categoryId);
		Task<List<ProductEntity>> FilterProductsForSearch(List<ProductEntity> products, List<FilterNameGetDTO> filters);
		Task<List<FilterNameShowDTO>> GetAvailableSearchFilters(List<ProductEntity> products, List<FilterNameGetDTO> active_filters, string? categoryId, string searchText);
		Task<List<CategorySearchDTO>> GetCategoriesFromProducts(List<ProductSearchDTO> products);
		Task<string?> GetCategoryBySearch(string categoryName);
		Task<List<FilterNameShowDTO>> GetBasicFiltersForSearch(List<ProductSearchDTO> products);
		Task<(int Min,int Max)> GetMinAndMaxPrice(List<ProductShowDTO> products);
		Task<List<ProductEntity?>> GetProductsBySearch(string searchText);
	}
}
