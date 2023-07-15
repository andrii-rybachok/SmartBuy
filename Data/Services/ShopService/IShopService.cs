using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Services.ShopService
{
	public interface IShopService
	{
		Task<CategoryShowDTO> GetCategoryById(string id);
		Task<List<CategoryItemDTO>> GetAllCategories();

		CategoryShowDTO GetProductByFilters(List<FilterNameGetDTO> filters, string categoryId);

		List<ProductEntity> GetProductByFilter(FilterNameGetDTO filter, List<ProductEntity> initialProducts);
	}
}
