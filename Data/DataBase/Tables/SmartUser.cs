using Microsoft.AspNetCore.Identity;

namespace SmartBuyApi.DataBase.Tables
{
	public class SmartUser : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string? Gender { get; set; }

		public IEnumerable<Adress> Adresses { get; set; }
	}
}
