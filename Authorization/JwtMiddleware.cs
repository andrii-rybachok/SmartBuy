namespace SmartBuyApi.Authorization;

using Microsoft.Extensions.Options;
using SmartBuyApi.Data.Services.UserService;


public class JwtMiddleware
{
	private readonly RequestDelegate _next;
	private readonly IConfiguration _configuration;

	public JwtMiddleware(RequestDelegate next, IConfiguration configuration)
	{
		_next = next;
		_configuration = configuration;
	}

	public async Task Invoke(HttpContext context, IUserService userService, IJwtUtils jwtUtils)
	{
		var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
		var userId = jwtUtils.ValidateJwtToken(token);
		if (userId != null)
		{

			context.Items["User"] = userService.GetById(userId);
		}

		await _next(context);
	}
}
