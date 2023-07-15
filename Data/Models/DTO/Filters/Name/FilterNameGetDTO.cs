using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.Models.DTO.Filters.Value;
using System;

namespace SmartBuyApi.Data.Models.DTO.Filters.Name
{
    public class FilterNameGetDTO : IEquatable<FilterNameGetDTO>
	{
        public string Name { get; set; }
        public List<FilterValueGetDTO> Values { get; set; }

		public bool Equals(FilterNameGetDTO? other)
		{
			return Name.Equals(other.Name);
		}
	}
}
