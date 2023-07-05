namespace SmartBuyApi.Authorization;

using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.DataBase;
using SmartBuyApi.DataBase.Tables;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;


public interface IJwtUtils
{
	public string GenerateJwtToken(SmartUser user);
	public string? ValidateJwtToken(string token);
	public RefreshToken GenerateRefreshToken(string ipAddress);
}

public class JwtUtils : IJwtUtils
{
	private ApplicationDbContext _context;
	private readonly IConfiguration _configuration;

	readonly int expiration_time =15;

	public JwtUtils(ApplicationDbContext context,IConfiguration configuration)
	{
		_context = context;
		_configuration = configuration;
	}

	public string GenerateJwtToken(SmartUser user)
	{
		// generate token that is valid for 15 minutes
		var tokenHandler = new JwtSecurityTokenHandler();
		var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
		var tokenDescriptor = new SecurityTokenDescriptor
		{
			Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id) }),
			Expires = DateTime.UtcNow.AddMinutes(expiration_time),
			SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
		};
		var token = tokenHandler.CreateToken(tokenDescriptor);
		return tokenHandler.WriteToken(token);
	}

	public string? ValidateJwtToken(string token)
	{
		if (token == null)
			return null;

		var tokenHandler = new JwtSecurityTokenHandler();
		var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
		try
		{
			tokenHandler.ValidateToken(token, new TokenValidationParameters
			{
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(key),
				ValidateIssuer = false,
				ValidateAudience = false,
				ClockSkew = TimeSpan.Zero
			}, out SecurityToken validatedToken);

			var jwtToken = (JwtSecurityToken)validatedToken;
			var userId = jwtToken.Claims.First(x => x.Type == "id").Value;

			return userId;
		}
		catch
		{
			return null;
		}
	}

	public RefreshToken GenerateRefreshToken(string ipAddress)
	{
		var refreshToken = new RefreshToken
		{
			Id = Guid.NewGuid().ToString(),
			Token = getUniqueToken(),
			Expires = DateTime.UtcNow.AddDays(7),
			Created = DateTime.UtcNow,
			CreatedByIp = ipAddress
		};

		return refreshToken;

		string getUniqueToken()
		{
			var token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
			var tokenIsUnique = !_context.Users.Any(u => u.RefreshTokens.Any(t => t.Token == token));

			if (!tokenIsUnique)
				return getUniqueToken();

			return token;
		}
	}
}