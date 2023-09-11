namespace SmartBuyApi.Data.Models.DTO.Filters.Value
{
    public class FilterValueGetDTO
    {
        public string? StringValue { get; set; }
		public double MinValue { get; set; }
		public double MaxValue { get; set; }

		public bool IsInRange(string? value)
		{
			if (value == null)
			{
				return false;
			}
			var number=double.Parse(value);
			if (number >= MinValue && number <= MaxValue)
			{
				return true;
			}
			return false;
		}
		public bool IsNumeric()
		{
			if (MaxValue != null && MinValue != null && MaxValue!=0&& MaxValue - MinValue >= 0)
			{
				return true;
			}
			return false;
		}
	}
}
