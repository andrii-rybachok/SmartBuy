using AutoMapper;
using Duende.IdentityServer.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SmartBuyApi.Authorization;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Filters.Name;
using SmartBuyApi.Data.Models.DTO.Product;
using SmartBuyApi.Data.Models.Responses;
using SmartBuyApi.Data.Services.ProductService;
using SmartBuyApi.Data.Services.ShopService;

namespace SmartBuyApi.Controllers
{

	[Route("api/shop")]
	[ApiController]
	public class ShopController : ControllerBase
	{
		private readonly IShopService _shopService;
		private readonly IMapper _mapper;
		private readonly IProductService _productService;
		private readonly IJwtUtils _jwtService;

		public ShopController(IShopService shopService, IMapper mapper, IProductService productService, IJwtUtils jwtService)
		{
			_shopService = shopService;
			_mapper = mapper;
			_productService = productService;
			_jwtService = jwtService;
		}

		[HttpGet("categories")]
		public async Task<IActionResult> GetAllCategories()
		{
			var categories = await _shopService.GetGlobalCategories();
			return Ok(categories);
		}


		[HttpGet("get-category")]
		public async Task<IActionResult> GetCategoryById(string categoryId)
		{
			var category = await _shopService.GetCategoryById(categoryId);
			if (category == null)
			{
				return BadRequest("This category doesnt exist");
			}
			return Ok(category);
		}
		[HttpPost("product-filter")]
		public async Task<IActionResult> GetProductsByFilters(string categoryId, List<FilterNameGetDTO> filterNames)
		{

			var category = await _shopService.GetCategoryByFilters(filterNames, categoryId);

			return Ok(category);
		}


		[HttpPost("search")]
		public async Task<IActionResult> FilterSearchProducts(string searchText, [FromBody(EmptyBodyBehavior = EmptyBodyBehavior.Allow)] List<FilterNameGetDTO>? filterNames)
		{

			if (filterNames == null)
			{
				return await GetProductsBySearch(searchText);
			}
			var filtersWithoutCategory = filterNames.ToList();
			var categoryFilter = filtersWithoutCategory.FirstOrDefault(x => x.Name == "Category");
			if (categoryFilter != null)
			{
				filtersWithoutCategory.Remove(categoryFilter);
			}
			SearchResponse response = new SearchResponse();
			var initialProducts = await _shopService.GetProductsBySearch(searchText);
			if (initialProducts != null)
			{

				var products = await _shopService.FilterProductsForSearch(initialProducts, filtersWithoutCategory);
				if (products.Count > 0)
				{
					List<FilterNameShowDTO> filters;
					response.Products = _mapper.Map<List<ProductSearchDTO>>(products);
					string? categoryId = categoryFilter.Name.IsNullOrEmpty() ? null : categoryFilter.Values.ElementAt(0).StringValue;
					filters = await _shopService.GetAvailableSearchFilters(products, filterNames, categoryId, searchText);
					response.Filters = filters;
					return Ok(response);
				}
			}
			return BadRequest("Nothing was found");

		}

		[HttpGet("promoted-products")]
		public async Task<IActionResult> GetPromotedProducts()
		{
			return Ok(_productService.GetPromotedProducts());
		}


		async Task<IActionResult> GetProductsBySearch(string searchText)
		{
			SearchResponse response = new SearchResponse();
			if (searchText.Length > 1)
			{
				var categoryId = await _shopService.GetCategoryBySearch(searchText);
				if (categoryId != null)
				{
					response.CategoryId = categoryId;
					return Ok(response);
				}
				var products = _mapper.Map<List<ProductEntity>, List<ProductSearchDTO>>(await _shopService.GetProductsBySearch(searchText));

				if (products != null && products.Count > 0)
				{
					var filters = await _shopService.GetBasicFiltersForSearch(products);
					response.Products = products;
					response.Filters = filters;
					return Ok(response);
				}
			}
			return NotFound("Nothing was founded");
		}

		[HttpGet("productById")]
		public async Task<IActionResult> GetProductById(string id)
		{
			var product = await _productService.GetProductByIdAsync(id);
			if (product == null)
			{
				return BadRequest("Invalid product id");
			}
			return Ok(product);
		}
		[Authorize]
		[HttpPost("like")]
		public async Task<IActionResult> LikeProductById(string productId)
		{
			var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
			var userId = _jwtService.ValidateJwtToken(token);

			var res = _productService.LikeProduct(userId, productId);
			return Ok();
		}
	}
}
