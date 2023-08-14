using SmartBuyApi.Data.DataBase.Tables;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBuyApi.Data.DataBase.Entities
{
	[Table("tbl_FilterNames")]

	public class FilterName
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string PublicName { get; set; }
		public string? Metric { get; set; }

		public string CategoryId { get; set; }
		public CategoryEntity Category { get; set; }

		public List<FilterValue> Values { get; set; }
		public FilterName() 
		{
			Values = new List<FilterValue>();
		}
	}
}
