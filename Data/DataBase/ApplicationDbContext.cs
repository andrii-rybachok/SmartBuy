using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartBuyApi.Data.DataBase;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.DataBase.Entities.SpecializedProducts;
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

		public DbSet<Telephone> Telephones { get; set; }
		public DbSet<Laptop> Laptops { get; set; }


		public DbSet<FilterName> FilterNames { get; set; }
		public DbSet<FilterValue> FilterValues { get; set; }

		public DbSet<ProductImageEntity> Images { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
			base.OnModelCreating(modelBuilder);

			new DbInitializer(modelBuilder).Seed();

			modelBuilder.Entity<SmartUser>()
				.ToTable("tbl_Users");
			modelBuilder.Entity<SmartUser>()
				.HasMany(x => x.RefreshTokens);

			modelBuilder.Entity<Adress>()
				.HasOne(x => x.User)
				.WithMany(x => x.Adresses);
			modelBuilder.Entity<Adress>()
				.ToTable("tbl_Adresses");

			modelBuilder.Entity<CategoryEntity>()
				.HasMany(x => x.FilterNames)
				.WithOne(x => x.Category)
				.HasForeignKey(x=>x.CategoryId);


			modelBuilder.Entity<FilterName>()
				.HasMany(x => x.Values)
				.WithOne(x => x.FilterName);

			modelBuilder.Entity<CategoryEntity>()
				.HasMany(x=>x.Products)
				.WithOne(x=>x.Category)
				.HasForeignKey(x=>x.CategoryId);
		}
	}
}
