using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Filters;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Models.DTO.Category
{
	public class CategoryShowDTO
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public List<FilterNameShowDTO> Filters { get; set; }
		public List<ProductShowDTO> Products { get; set; }
	}
}
