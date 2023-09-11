using SmartBuyApi.Data.DataBase.Tables;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBuyApi.Data.DataBase.Entities
{
	[Table("tbl_GlobalCategories")]

	public class GlobalCategoryEntity
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public ImageEntity Image { get; set; }
		public List<CategoryEntity> Categories { get; set; }
	}
}
