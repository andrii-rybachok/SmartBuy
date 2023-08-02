using AutoMapper;
using Duende.IdentityServer.Extensions;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Filters.Value;
using SmartBuyApi.Data.Models.DTO.Product;
using SmartBuyApi.Data.Models.DTO.Users;
using SmartBuyApi.DataBase.Tables;

namespace SmartBuyApi.Data.Mappers
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<CategoryEntity, CategoryItemDTO>();

            CreateMap<CategoryCreateDTO, CategoryEntity>()
                .ForMember(x => x.Image, opt => opt.Ignore());

			CreateMap<UserRegister, SmartUser>();


			CreateMap<ProductEntity, ProductItemDTO>()
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name));
            CreateMap<ProductCreateDTO, ProductEntity>()
                .ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId.IsNullOrEmpty() ? null : x.CategoryId));

            CreateMap<ProductEntity, ProductShowDTO>()
                .ForMember(x => x.Rating, opt => opt.MapFrom(s => s.Rating))
                .ForMember(x=>x.CountOfReviews,opt=>opt.MapFrom(s=>s.Comments.Count))
                .ForMember(x=>x.ImageName,opt=>opt.MapFrom(s=>s.Images.FirstOrDefault(x=>x.Priority==1).Name));

			CreateMap<FilterValue, FilterValueShowDTO>();

			CreateMap<FilterValue, FilterValueGetDTO>();

			CreateMap<FilterName, FilterNameGetDTO>();
			CreateMap<FilterName, FilterNameShowDTO>();

            CreateMap<CategoryEntity, CategoryShowDTO>()
                .ForMember(x=>x.Filters,act=>act.MapFrom(x=>x.FilterNames));

			CreateMap<CategoryEntity, CategoryGetDTO>()
				.ForMember(x => x.Filters, act => act.MapFrom(x => x.FilterNames));

            CreateMap<CategoryEntity, CategorySearchDTO>();
            CreateMap<ProductEntity, ProductSearchDTO>();

		}
	}
}