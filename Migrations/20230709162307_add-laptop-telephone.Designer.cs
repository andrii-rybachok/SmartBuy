﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartBuyApi.DataBase;

#nullable disable

namespace SmartBuyApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230709162307_add-laptop-telephone")]
    partial class addlaptoptelephone
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Entities.FilterName", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("tbl_FilterNames");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Entities.FilterValue", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FilterNameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("NumericValue")
                        .HasColumnType("float");

                    b.Property<string>("PublicValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StringValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilterNameId");

                    b.ToTable("tbl_FilterValues");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Entities.RefreshToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByIp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReasonRevoked")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReplacedByToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime2");

                    b.Property<string>("RevokedByIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmartUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SmartUserId");

                    b.ToTable("tbl_Tokens");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Tables.CategoryEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastEdit")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Categories");

                    b.HasData(
                        new
                        {
                            Id = "imwccWSupND",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4608),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "description",
                            Image = "1.jpg",
                            IsDelete = false,
                            Name = "Комп'ютери та ноутбуки"
                        },
                        new
                        {
                            Id = "r0HHeNteua_",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4667),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "description",
                            Image = "1.jpg",
                            IsDelete = false,
                            Name = "Смартфони"
                        },
                        new
                        {
                            Id = "sLeo04PkfFB",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4671),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "description",
                            Image = "1.jpg",
                            IsDelete = false,
                            Name = "Побутова техніка"
                        },
                        new
                        {
                            Id = "e_6hvI6stRf",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4676),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "description",
                            Image = "1.jpg",
                            IsDelete = false,
                            Name = "Дача, сад, город"
                        },
                        new
                        {
                            Id = "P1VxJlSTS_J",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4680),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "description",
                            Image = "1.jpg",
                            IsDelete = false,
                            Name = "Спорт і захоплення"
                        },
                        new
                        {
                            Id = "h3zqBJjNnN1",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4686),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "description",
                            Image = "1.jpg",
                            IsDelete = false,
                            Name = "Офіс, школа, книги"
                        },
                        new
                        {
                            Id = "q01B9XSzO7u",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4689),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "description test",
                            Image = "1.jpg",
                            IsDelete = false,
                            Name = "test"
                        });
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Tables.ProductEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastEdit")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("tbl_Products");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ProductEntity");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = "obsHt7jAbxE",
                            CategoryId = "imwccWSupND",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4809),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test",
                            IsDelete = false,
                            Name = "ПК Х123434",
                            Price = 436765,
                            ShortDescription = "figna"
                        },
                        new
                        {
                            Id = "s9ZEVypPBYV",
                            CategoryId = "r0HHeNteua_",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4816),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .",
                            IsDelete = false,
                            Name = "iHunt Titan P13000 PRO 2021",
                            Price = 13940,
                            ShortDescription = "figna"
                        },
                        new
                        {
                            Id = "pLN08ZDb3im",
                            CategoryId = "sLeo04PkfFB",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4820),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Холодильники з системою NeoFrost ",
                            IsDelete = false,
                            Name = "BEKO CNA295K20XP",
                            Price = 10999,
                            ShortDescription = "figna"
                        },
                        new
                        {
                            Id = "GlgpC9iRmPg",
                            CategoryId = "e_6hvI6stRf",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4825),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ланцюгова пила Bosch UniversalChain ",
                            IsDelete = false,
                            Name = "Bosch UniversalChain 40",
                            Price = 3958,
                            ShortDescription = "figna"
                        },
                        new
                        {
                            Id = "wxFFIrerH11",
                            CategoryId = "P1VxJlSTS_J",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4828),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Велосипед Champion Spark 29 ",
                            IsDelete = false,
                            Name = "Champion Spark 29 19.5 Black-neon yellow-white",
                            Price = 5460,
                            ShortDescription = "figna"
                        },
                        new
                        {
                            Id = "NkNp_HlpUVb",
                            CategoryId = "h3zqBJjNnN1",
                            DateCreated = new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4833),
                            DateLastEdit = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ",
                            IsDelete = false,
                            Name = "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла",
                            Price = 1199,
                            ShortDescription = "figna"
                        });
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Tables.ProductImageEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("tbl_ProductImages");
                });

            modelBuilder.Entity("SmartBuyApi.DataBase.Tables.Adress", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("House")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("tbl_Adresses", (string)null);
                });

            modelBuilder.Entity("SmartBuyApi.DataBase.Tables.SmartUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("tbl_Users", (string)null);
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Entities.SpecializedProducts.Laptop", b =>
                {
                    b.HasBaseType("SmartBuyApi.Data.DataBase.Tables.ProductEntity");

                    b.Property<string>("GraphicCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("tbl_Products");

                    b.HasDiscriminator().HasValue("Laptop");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Entities.SpecializedProducts.Telephone", b =>
                {
                    b.HasBaseType("SmartBuyApi.Data.DataBase.Tables.ProductEntity");

                    b.Property<int>("BatteryCapacity")
                        .HasColumnType("int");

                    b.Property<float>("DisplayDiagonal")
                        .HasColumnType("real");

                    b.ToTable("tbl_Products");

                    b.HasDiscriminator().HasValue("Telephone");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SmartBuyApi.DataBase.Tables.SmartUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SmartBuyApi.DataBase.Tables.SmartUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartBuyApi.DataBase.Tables.SmartUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SmartBuyApi.DataBase.Tables.SmartUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Entities.FilterName", b =>
                {
                    b.HasOne("SmartBuyApi.Data.DataBase.Tables.CategoryEntity", "Category")
                        .WithMany("FilterNames")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Entities.FilterValue", b =>
                {
                    b.HasOne("SmartBuyApi.Data.DataBase.Entities.FilterName", "FilterName")
                        .WithMany("Values")
                        .HasForeignKey("FilterNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterName");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Entities.RefreshToken", b =>
                {
                    b.HasOne("SmartBuyApi.DataBase.Tables.SmartUser", null)
                        .WithMany("RefreshTokens")
                        .HasForeignKey("SmartUserId");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Tables.ProductEntity", b =>
                {
                    b.HasOne("SmartBuyApi.Data.DataBase.Tables.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Tables.ProductImageEntity", b =>
                {
                    b.HasOne("SmartBuyApi.Data.DataBase.Tables.ProductEntity", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SmartBuyApi.DataBase.Tables.Adress", b =>
                {
                    b.HasOne("SmartBuyApi.DataBase.Tables.SmartUser", "User")
                        .WithMany("Adresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Entities.FilterName", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Tables.CategoryEntity", b =>
                {
                    b.Navigation("FilterNames");
                });

            modelBuilder.Entity("SmartBuyApi.Data.DataBase.Tables.ProductEntity", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("SmartBuyApi.DataBase.Tables.SmartUser", b =>
                {
                    b.Navigation("Adresses");

                    b.Navigation("RefreshTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
