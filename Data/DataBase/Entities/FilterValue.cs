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

		public bool IsInRange(string? value)
		{
			if (value == null)
			{
				return false;
			}
			var number = double.Parse(value);
			if (number >= MinValue && number <= MaxValue)
			{
				return true;
			}
			return false;
		}
		public bool IsNumeric()
		{
			if (MaxValue != null && MinValue != null && MaxValue != 0 && MaxValue - MinValue >= 0)
			{
				return true;
			}
			return false;
		}
	}
}
