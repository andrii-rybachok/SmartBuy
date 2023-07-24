using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Drawing;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SmartBuyAPI.Helpers;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.DataBase;

namespace SmartBuyAPI.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductEntity _productService;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _iconfiguration;

       
    }
}