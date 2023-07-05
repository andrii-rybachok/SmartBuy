using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartBuyApi.Authorization;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.Models.DTO.Users;
using SmartBuyApi.DataBase;
using SmartBuyApi.DataBase.Tables;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SmartBuyApi.Data.Services.UserService
{
    public class UserService : IUserService
	{
		private IJwtUtils _jwtUtils;
		private readonly IConfiguration _configuration;
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly ApplicationDbContext _context;
		private readonly SignInManager<SmartUser> _signInManager;

		public UserService(IJwtUtils jwtUtils, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, SignInManager<SmartUser> signInManager, ApplicationDbContext context)
		{
			_jwtUtils = jwtUtils;
			_configuration = configuration;
			_httpContextAccessor = httpContextAccessor;
			_signInManager = signInManager;
			_context = context;
		}


		public async Task<UserDetails> Authenticate(UserLogin model, string ipAddress)
		{
			var user = _context.Users.SingleOrDefault(x => x.Email == model.Email);

			var isPasswordRight =await _signInManager.CheckPasswordSignInAsync(user,model.Password,false);
			if (user == null || !isPasswordRight.Succeeded)
				throw new Exception("Username or password is incorrect");

			// authentication successful so generate jwt and refresh tokens
			var jwtToken = _jwtUtils.GenerateJwtToken(user);
			var refreshToken = _jwtUtils.GenerateRefreshToken(ipAddress);
			user.RefreshTokens.Add(refreshToken);

			// remove old refresh tokens from user
			removeOldRefreshTokens(user);

			// save changes to db
			_context.Update(user);
			_context.SaveChanges();

			return new UserDetails(user.Id,user.FirstName,user.LastName,user.Email,jwtToken,refreshToken.Token);
		}

		public UserDetails RefreshToken(string token, string ipAddress)
		{
			var user = getUserByRefreshToken(token);
			var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

			if (refreshToken.IsRevoked)
			{
				// revoke all descendant tokens in case this token has been compromised
				revokeDescendantRefreshTokens(refreshToken, user, ipAddress, $"Attempted reuse of revoked ancestor token: {token}");
				_context.Update(user);
				_context.SaveChanges();
			}

			if (!refreshToken.IsActive)
				throw new Exception("Invalid token");

			// replace old refresh token with a new one (rotate token)
			var newRefreshToken = rotateRefreshToken(refreshToken, ipAddress);
			user.RefreshTokens.Add(newRefreshToken);

			// remove old refresh tokens from user
			removeOldRefreshTokens(user);

			// save changes to db
			_context.Update(user);
			_context.SaveChanges();

			var jwtToken = _jwtUtils.GenerateJwtToken(user);

			return new  UserDetails(user.Id, user.FirstName, user.LastName, user.Email, jwtToken, refreshToken.Token);
		}

		public bool RevokeToken(string token, string ipAddress)
		{
			var user = getUserByRefreshToken(token);
			var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

			if (!refreshToken.IsActive)
				return false;

			// revoke token and save
			revokeRefreshToken(refreshToken, ipAddress, "Revoked without replacement");
			_context.Update(user);
			_context.SaveChanges();
			return true;
		}

		public IEnumerable<SmartUser> GetAll()
		{
			return _context.Users;
		}

		public SmartUser GetById(string id)
		{
			var user = _context.Users.Find(id);
			if (user == null) throw new KeyNotFoundException("User not found");
			return user;
		}



		private SmartUser getUserByRefreshToken(string token)
		{
			var user = _context.Users.Include(x=>x.RefreshTokens).SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

			if (user == null)
				throw new Exception("Invalid token");

			return user;
		}

		private RefreshToken rotateRefreshToken(RefreshToken refreshToken, string ipAddress)
		{
			var newRefreshToken = _jwtUtils.GenerateRefreshToken(ipAddress);
			revokeRefreshToken(refreshToken, ipAddress, "Replaced by new token", newRefreshToken.Token);
			return newRefreshToken;
		}

		private void removeOldRefreshTokens(SmartUser user)
		{
		
			user.RefreshTokens.RemoveAll(x =>
				!x.IsActive &&
				x.Created.AddDays(int.Parse(_configuration["Jwt:RefreshTokenTTL"])) <= DateTime.UtcNow);
		}

		private void revokeDescendantRefreshTokens(RefreshToken refreshToken, SmartUser user, string ipAddress, string reason)
		{
			// recursively traverse the refresh token chain and ensure all descendants are revoked
			if (!string.IsNullOrEmpty(refreshToken.ReplacedByToken))
			{
				var childToken = user.RefreshTokens.SingleOrDefault(x => x.Token == refreshToken.ReplacedByToken);
				if (childToken.IsActive)
					revokeRefreshToken(childToken, ipAddress, reason);
				else
					revokeDescendantRefreshTokens(childToken, user, ipAddress, reason);
			}
		}

		private void revokeRefreshToken(RefreshToken token, string ipAddress, string reason = null, string replacedByToken = null)
		{
			token.Revoked = DateTime.UtcNow;
			token.RevokedByIp = ipAddress;
			token.ReasonRevoked = reason;
			token.ReplacedByToken = replacedByToken;
		}
	}
}
