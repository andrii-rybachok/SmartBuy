using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartBuyApi.Data.Models.DTO;
using SmartBuyApi.Data.Services;
using SmartBuyApi.DataBase.Tables;

namespace SmartBuyApi.Controllers
{
    [Route("api/shop")]
	[ApiController]
	public class IdentityController : ControllerBase
	{
		private readonly UserManager<SmartUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly SignInManager<SmartUser> _signInManager;
		private readonly TokenService _tokenService;
		private readonly IMapper _mapper;
		public IdentityController(IMapper mapper, SignInManager<SmartUser> signInManager, RoleManager<IdentityRole> manager, UserManager<SmartUser> userManager, TokenService tokenService)
		{
			_mapper = mapper;
			_userManager = userManager;
			_roleManager = manager;
			_signInManager = signInManager;
			_tokenService = tokenService;
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
		[HttpPost("SignIn")]
		public async Task<IActionResult> SignIn(UserLogin userModel)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(userModel.Email);
				var result = await _signInManager.PasswordSignInAsync(user, userModel.Password, false, false);
				if (result.Succeeded)
				{

					var token = _tokenService.CreateToken(user);
					return Ok(token);
				}
				if (result.IsLockedOut)
				{
					return BadRequest("User acc is locked out");
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Invalid login attempt.");
					return BadRequest(ModelState);
				}
			}
			return BadRequest(ModelState);

		}
	}
}
