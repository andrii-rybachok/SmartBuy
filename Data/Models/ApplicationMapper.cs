using AutoMapper;
using SmartBuyApi.Data.Models.DTO;
using SmartBuyApi.DataBase.Tables;

namespace SmartBuyApi.Data.Models
{
    public class ApplicationMapper :Profile
	{
		public ApplicationMapper() {
			CreateMap<UserRegister, SmartUser>();
		}
	}
}
