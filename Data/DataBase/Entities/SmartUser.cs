using Microsoft.AspNetCore.Identity;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.DataBase.Tables;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBuyApi.DataBase.Tables
{

	public class SmartUser : IdentityUser
	{
		public SmartUser()
		{
			RefreshTokens = new List<RefreshToken>();
			Comments= new List<ReviewEntity>();
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string? Gender { get; set; }

		public List<ReviewEntity> Comments { get; set; }
		public IEnumerable<Adress> Adresses { get; set; }

		public List<ProductEntity> LikedProducts { get; set; }
		public List<RefreshToken> RefreshTokens { get; set; }
		
	}
}
