using AutoMapper;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartBuyApi.Authorization;
using SmartBuyApi.Data.Models.DTO.Users;
using SmartBuyApi.Data.Services;
using SmartBuyApi.Data.Services.UserService;
using SmartBuyApi.DataBase.Tables;

namespace SmartBuyApi.Controllers
{
	[Authorize]
	[Route("api/shop")]
	[ApiController]
	public class IdentityController : ControllerBase
	{
		private readonly UserManager<SmartUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly IUserService _userService;
		private readonly IMapper _mapper;
		public IdentityController(IMapper mapper, RoleManager<IdentityRole> manager,
			UserManager<SmartUser> userManager,IUserService userService)
		{
			_mapper = mapper;
			_userManager = userManager;
			_roleManager = manager;
			_userService = userService;
		}

		[HttpPost("roleCreator")]
		public async Task<IActionResult> CreateRole(string roleName)
		{
			if (ModelState.IsValid)
			{
				var role = new IdentityRole();
				role.Name = roleName;
				var result = await _roleManager.CreateAsync(role);
				if (result.Succeeded)
				{
					return Created("", roleName);
				}
				if (!result.Succeeded)
				{
					foreach (var error in result.Errors)
					{
						ModelState.TryAddModelError(error.Code, error.Description);
					}
					return BadRequest(ModelState);
				}
			}
			return BadRequest();

		}

		[AllowAnonymous]
		[HttpPost("refresh-token")]
		public IActionResult RefreshToken()
		{
			var refreshToken = Request.Cookies["refreshToken"];
			var response = _userService.RefreshToken(refreshToken, ipAddress());
			setTokenCookie(response.RefreshToken);
			return Ok(response);
		}
		[AllowAnonymous]
		[HttpPost("log-out")]
		public IActionResult LogOut()
		{
			var token = Request.Cookies["refreshToken"];

			if (string.IsNullOrEmpty(token))
				return BadRequest(new { message = "Token is required" });


			_userService.RevokeToken(token, ipAddress());
			removeToken(token);
			return Ok(new { message = "Logged out" });
		}

		

		[HttpGet]
		public IActionResult GetAll()
		{
			var users = _userService.GetAll();
			return Ok(users);
		}
		[AllowAnonymous]
		[HttpPost("Register")]
		public async Task<IActionResult> Register(UserRegister userModel)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest("dasd");
			}
			var user = _mapper.Map<SmartUser>(userModel);
			user.UserName=userModel.FirstName;
			var result = await _userManager.CreateAsync(user, userModel.Password);
			if (!result.Succeeded)
			{
				foreach (var error in result.Errors)
				{
					ModelState.TryAddModelError(error.Code, error.Description);
				}
				return BadRequest(ModelState);
			}
			await _userManager.AddToRoleAsync(user, "customer");
			return Created("", user);
		}

		[AllowAnonymous]
		[HttpPost("authenticate")]
		public async Task<IActionResult> Authenticate(UserLogin request)
		{
			
			var response =await _userService.Authenticate(request, ipAddress());
			setTokenCookie(response.RefreshToken);
			return Ok(response);

		}
		private void setTokenCookie(string token)
		{
			
			var cookieOptions = new CookieOptions
			{
				HttpOnly = true,
				Expires = DateTime.UtcNow.AddDays(7),
				Secure = true,
				SameSite = SameSiteMode.None,
			};
			Response.Cookies.Append("refreshToken", token, cookieOptions);
		}

		private void removeToken(string token)
		{
			Response.Cookies.Delete("refreshToken");
		}
		private string ipAddress()
		{
			if (Request.Headers.ContainsKey("X-Forwarded-For"))
				return Request.Headers["X-Forwarded-For"];
			else
				return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
		}
	}
}
