using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Services.ProductService
{
	public interface IProductService
	{
		List<ProductShowDTO> GetPromotedProducts();
		Task<List<ProductShowDTO>> GetLastSeenProducts(string[] productIds);

	}
}
