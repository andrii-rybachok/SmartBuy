using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Models.Responses
{
	public class SearchResponse
	{
		public string CategoryId { get; set; }
		public List<ProductSearchDTO> Products { get; set; }

		public List<FilterNameShowDTO> Filters { get; set; }

	}
}
