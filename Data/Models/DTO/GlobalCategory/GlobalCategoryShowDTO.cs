using SmartBuyApi.Data.Models.DTO.Category;

namespace SmartBuyApi.Data.Models.DTO.GlobalCategory
{
	public class GlobalCategoryShowDTO
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public List<CategoryItemDTO> Categories { get; set; }

	}
}
