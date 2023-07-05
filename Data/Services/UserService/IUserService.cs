using SmartBuyApi.Data.Models.DTO.Users;
using SmartBuyApi.DataBase.Tables;

namespace SmartBuyApi.Data.Services.UserService
{
    public interface IUserService
	{
		 Task<UserDetails> Authenticate(UserLogin model, string ipAddress);
		UserDetails RefreshToken(string token, string ipAddress);
		bool RevokeToken(string token, string ipAddress);
		IEnumerable<SmartUser> GetAll();
		SmartUser GetById(string id);
	}
}
