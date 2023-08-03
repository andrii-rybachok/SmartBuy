using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBuyApi.DataBase.Tables
{
	public class Adress
	{
		public string Id { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public int House { get; set; }
		public string Flat { get; set; }

		public SmartUser User { get; set; }

	}
}
