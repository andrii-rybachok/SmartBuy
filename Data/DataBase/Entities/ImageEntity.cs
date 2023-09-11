using SmartBuyApi.Data.DataBase.Tables;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBuyApi.Data.DataBase.Entities
{

	public class ImageEntity
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Priority { get; set; }
		public ProductEntity? Product { get; set; }
		public CategoryEntity? Category { get; set; }
		public GlobalCategoryEntity? GlobalCategory { get; set; }
		public string? CategoryId { get; set; }
		public string? GlobalCategoryId { get; set; }

		public string? ProductId { get; set; }
	}
}
