using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD:Data/DataBase/ApplicationDbContext.cs
using SmartBuyApi.Data.DataBase.Entities;
=======
using SmartBuyApi.Data.DataBase;
using SmartBuyApi.Data.DataBase.Tables;
>>>>>>> 56bbb87620c79ef3720b012d5a925e67d1cf3b74:Data/DataBase/ApplicationDbContext .cs
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
<<<<<<< HEAD:Data/DataBase/ApplicationDbContext.cs
		public DbSet<RefreshToken> Tokens { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);



			modelBuilder.Entity<SmartUser>()
				.HasMany(x=>x.RefreshTokens);
			modelBuilder.Entity<SmartUser>()
=======
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

            new DbInitializer(modelBuilder).Seed();
            modelBuilder.Entity<SmartUser>()
>>>>>>> 56bbb87620c79ef3720b012d5a925e67d1cf3b74:Data/DataBase/ApplicationDbContext .cs
				.ToTable("Users");
			modelBuilder.Entity<Adress>()
				.HasOne(x => x.User)
				.WithMany(x => x.Adresses);
		}
	}
}
