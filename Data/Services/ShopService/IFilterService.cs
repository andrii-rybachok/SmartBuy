using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.GlobalCategory;
using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Services.ShopService
{
	public interface IFilterService
	{

		List<ProductEntity> GetProductsByFilters(List<ProductEntity> base_products, List<FilterNameGetDTO> filters);
		Task<List<ProductEntity>> FilterProductsForSearch(List<ProductEntity> products, List<FilterNameGetDTO> filters);
		Task<List<FilterNameShowDTO>> GetAvailableSearchFilters(List<ProductEntity> products, List<FilterNameGetDTO> active_filters, string? categoryId, string searchText);
		Task<List<FilterNameShowDTO>> GetBasicFiltersForSearch(List<ProductSearchDTO> products);
        Task<List<ProductEntity?>> GetProductsBySearchString(string searchText);
        List<FilterNameShowDTO> GetMatchedFilters(List<FilterNameShowDTO> basic_filters, List<FilterNameGetDTO?> active_filters, List<ProductEntity> products);

		Task<List<FilterNameShowDTO>> GetBasicFiltersAsync(List<ProductShowDTO> products);

    }
}
