using SmartBuyApi.Data.DataBase.Tables;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBuyApi.Data.DataBase.Entities
{
	[Table("tbl_FilterValues")]

	public class FilterValue
	{
		public string Id { get; set; }
		public string? StringValue { get; set; }

		public double MinValue { get; set; }
		public double MaxValue { get; set; }

		public string PublicValue { get; set; }

		public string FilterNameId { get; set; }
		public FilterName FilterName { get; set; }

	
	}
}
