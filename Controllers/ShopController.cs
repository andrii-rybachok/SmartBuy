using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartBuyApi.Authorization;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.Data.Models.DTO.Filters;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Services.ShopService;
using SmartBuyApi.Data.Services.UserService;

namespace SmartBuyApi.Controllers
{

	[Route("api/shop")]
	[ApiController]
	public class ShopController : ControllerBase
	{
		private readonly IShopService _shopService;

		public ShopController(IShopService shopService)
		{
			_shopService = shopService;
		}

		[HttpGet("categories")]
		public async Task<IActionResult> GetAllCategories()
		{
			var categories = await _shopService.GetAllCategories();
			return Ok(categories);
		}


		[HttpGet("get-category")]
		public async Task<IActionResult> GetCategoryById(string categoryId)
		{
			var category = await _shopService.GetCategoryById(categoryId);
			return Ok(category);
		}
		[HttpPost("product-filter")]
		public async Task<IActionResult> GetByFilters(string categoryId,  List<FilterNameGetDTO> filterNames)
		{
			var category = _shopService.GetProductByFilters(filterNames, categoryId);
			return Ok(category);
		}
	}
}
