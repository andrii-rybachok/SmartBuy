using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Services.ProductService
{
	public interface IProductService
	{
		List<ProductShowDTO> GetPromotedProducts();
		Task<List<ProductShowDTO>> GetLastSeenProducts(string[] productIds);
		Task<ProductDetailDTO> GetProductByIdAsync(string id);
		ProductEntity LikeProduct(string userId, string productId);
		
    }
}
