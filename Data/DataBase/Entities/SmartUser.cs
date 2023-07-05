using Microsoft.AspNetCore.Identity;
using SmartBuyApi.Data.DataBase.Entities;

namespace SmartBuyApi.DataBase.Tables
{
    public class SmartUser : IdentityUser
	{
		public SmartUser()
		{
			RefreshTokens = new List<RefreshToken>();
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string? Gender { get; set; }

		public IEnumerable<Adress> Adresses { get; set; }

		public List<RefreshToken> RefreshTokens { get; set; }
	}
}
