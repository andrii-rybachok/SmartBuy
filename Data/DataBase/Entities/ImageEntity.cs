using SmartBuyApi.Data.DataBase.Tables;

namespace SmartBuyApi.Data.DataBase.Entities
{
	public class ImageEntity
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Priority { get; set; }
		public ProductEntity? Product { get; set; }
		public CategoryEntity? Category { get; set; }
		public string? CategoryId { get; set; }
		public string? ProductId { get; set; }
	}
}
