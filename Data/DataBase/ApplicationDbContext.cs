using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.DataBase.Tables;
using System.Drawing;

namespace SmartBuyApi.DataBase
{
    public class ApplicationDbContext : IdentityDbContext<SmartUser, IdentityRole, string>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
		{
		}
		public DbSet<Adress> Adresses { get; set; }
		public DbSet<RefreshToken> Tokens { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);



			modelBuilder.Entity<SmartUser>()
				.HasMany(x=>x.RefreshTokens);
			modelBuilder.Entity<SmartUser>()
				.ToTable("Users");
			modelBuilder.Entity<Adress>()
				.HasOne(x => x.User)
				.WithMany(x => x.Adresses);
		}
	}
}
