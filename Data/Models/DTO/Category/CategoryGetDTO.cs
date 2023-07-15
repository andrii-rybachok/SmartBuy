using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Models.DTO.Category
{
	public class CategoryGetDTO
	{
		public string Name { get; set; }

		public List<FilterNameGetDTO> Filters { get; set; }
		public List<ProductShowDTO> Products { get; set; }
	}
}
