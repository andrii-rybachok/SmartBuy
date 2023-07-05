using System.Text.Json.Serialization;

namespace SmartBuyApi.Data.Models.DTO.Users
{
    public class UserDetails
    {
		public UserDetails(string id, string firstName, string lastName, string email, string jwtToken, string refreshToken)
		{
			Id = id;
			
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			JwtToken = jwtToken;
			RefreshToken = refreshToken;
		}

		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string JwtToken { get; set; }

		[JsonIgnore] 
		public string RefreshToken { get; set; }

	}
}
