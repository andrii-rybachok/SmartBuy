
using SmartBuyApi.Data.Models.DTO.Filters.Value;

namespace SmartBuyApi.Data.Models.DTO.Filters.Name
{
    public class FilterNameShowDTO
    {
		public string Id { get; set; }
		public string Name { get; set; }
		public string PublicName { get; set; }
		public List<FilterValueShowDTO> Values { get; set; }
		
	}
}
