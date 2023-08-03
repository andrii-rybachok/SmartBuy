using SmartBuyApi.Data.Models.DTO.Category;

namespace SmartBuyApi.Data.Models.Responses
{
	public class FilterResponse
	{
		public CategoryShowDTO Category { get; set; }
		public int MinPrice { get; set; }
		public int MaxPrice { get; set; }

	}
}
