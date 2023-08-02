using SmartBuyApi.Data.Models.DTO.Category;

namespace SmartBuyApi.Data.Models.DTO.Product
{
	public class ProductSearchDTO:ProductShowDTO
	{
		public CategorySearchDTO Category { get; set; }
	}
}
