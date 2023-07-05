using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartBuyApi.Data.DataBase;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.DataBase.Tables;


using SmartBuyApi.DataBase.Tables;


namespace SmartBuyApi.DataBase
{
    public class ApplicationDbContext : IdentityDbContext<SmartUser, IdentityRole, string>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
		{
		}

		public DbSet<RefreshToken> Tokens { get; set; }

		public DbSet<Adress> Adresses { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
			base.OnModelCreating(modelBuilder);

			new DbInitializer(modelBuilder).Seed();

			modelBuilder.Entity<SmartUser>()
				.HasMany(x => x.RefreshTokens);
			modelBuilder.Entity<SmartUser>()
				.ToTable("Users");
			modelBuilder.Entity<Adress>()
				.HasOne(x => x.User)
				.WithMany(x => x.Adresses);
		}
	}
}
