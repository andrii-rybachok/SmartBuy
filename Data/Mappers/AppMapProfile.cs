using AutoMapper;
using Duende.IdentityServer.Extensions;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Filters.Value;
using SmartBuyApi.Data.Models.DTO.GlobalCategory;
using SmartBuyApi.Data.Models.DTO.Image;
using SmartBuyApi.Data.Models.DTO.Product;
using SmartBuyApi.Data.Models.DTO.Users;
using SmartBuyApi.DataBase.Tables;

namespace SmartBuyApi.Data.Mappers
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<CategoryEntity, CategoryItemDTO>()
                .ForMember(x=>x.Image,opt=>opt.MapFrom(s=>s.Image.Name));

            CreateMap<CategoryCreateDTO, CategoryEntity>()
                .ForMember(x => x.Image, opt => opt.Ignore());

			CreateMap<UserRegister, SmartUser>();
			CreateMap<ImageEntity, ImageShowDTO>();

			CreateMap<ProductEntity, ProductItemDTO>()
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name));
            CreateMap<ProductCreateDTO, ProductEntity>()
                .ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId.IsNullOrEmpty() ? null : x.CategoryId));

            CreateMap<ProductEntity, ProductShowDTO>()
                .ForMember(x => x.Rating, opt => opt.MapFrom(s => s.Rating))
                .ForMember(x=>x.CountOfReviews,opt=>opt.MapFrom(s=>s.Reviews.Count))
                .ForMember(x=>x.ImageName,opt=>opt.MapFrom(s=>s.Images.FirstOrDefault(x=>x.Priority==1).Name))
                .ForMember(x=>x.IsLiked,opt=>opt.MapFrom(s=>!s.UserLikeId.IsNullOrEmpty()));

			CreateMap<FilterValue, FilterValueShowDTO>();

			CreateMap<FilterValue, FilterValueGetDTO>();

			CreateMap<FilterName, FilterNameGetDTO>();
			CreateMap<FilterName, FilterNameShowDTO>();
            CreateMap<FilterNameShowDTO, FilterNameGetDTO>();
            CreateMap<CategoryEntity, CategoryShowDTO>()
                .ForMember(x=>x.Filters,act=>act.MapFrom(x=>x.FilterNames));
			CreateMap<GlobalCategoryEntity, GlobalCategoryShowDTO>()
                .ForMember(x=>x.Image,opt=>opt.MapFrom(s=>s.Image.Name))
                .ForMember(x=>x.Categories,opt=>opt.MapFrom(s=>s.Categories));
            
			CreateMap<CategoryEntity, CategoryGetDTO>()
				.ForMember(x => x.Filters, act => act.MapFrom(x => x.FilterNames));

            CreateMap<CategoryEntity, CategorySearchDTO>();
            CreateMap<ProductEntity, ProductSearchDTO>();

		}
	}
}