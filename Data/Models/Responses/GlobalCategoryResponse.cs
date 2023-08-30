using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.GlobalCategory;
using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Models.Responses
{
	public class GlobalCategoryResponse
	{
		public GlobalCategoryShowDTO GlobalCategory { get; set; }
		public List<ProductShowDTO> Products { get; set; }
		public List<FilterNameShowDTO> Filters { get; set; }
	}
}
