using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class cart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_cart",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_GlobalCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_GlobalCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_cartItem",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_cartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_cartItem_tbl_cart_CartId",
                        column: x => x.CartId,
                        principalTable: "tbl_cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastEdit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    GlobalCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Categories_tbl_GlobalCategories_GlobalCategoryId",
                        column: x => x.GlobalCategoryId,
                        principalTable: "tbl_GlobalCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_tbl_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_tbl_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_tbl_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_tbl_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Adresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    House = table.Column<int>(type: "int", nullable: false),
                    Flat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Adresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Adresses_tbl_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Tokens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonRevoked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmartUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Tokens_tbl_Users_SmartUserId",
                        column: x => x.SmartUserId,
                        principalTable: "tbl_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_FilterNames",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Metric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FilterNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_FilterNames_tbl_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tbl_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Dicount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastEdit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserLikeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<double>(type: "float", nullable: true),
                    BatteryCapacity = table.Column<int>(type: "int", nullable: true),
                    DisplayDiagonal = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Products_tbl_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tbl_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Products_tbl_Users_UserLikeId",
                        column: x => x.UserLikeId,
                        principalTable: "tbl_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_FilterValues",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StringValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinValue = table.Column<double>(type: "float", nullable: false),
                    MaxValue = table.Column<double>(type: "float", nullable: false),
                    PublicValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilterNameId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FilterValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_FilterValues_tbl_FilterNames_FilterNameId",
                        column: x => x.FilterNameId,
                        principalTable: "tbl_FilterNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GlobalCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_tbl_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tbl_Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_tbl_GlobalCategories_GlobalCategoryId",
                        column: x => x.GlobalCategoryId,
                        principalTable: "tbl_GlobalCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_tbl_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tbl_Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Reviews",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<long>(type: "bigint", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Advantages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disadvantages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Reviews_tbl_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Reviews_tbl_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "tbl_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tbl_GlobalCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1JegB5Au-fY", "Смартфони та планшети" },
                    { "6dXRub-fheD", "Електронні гаджети" },
                    { "aMjKdO9YBRK", "Аудіо" },
                    { "bHHSXzKC1tu", "Електро-інструменти" },
                    { "KAN4V6vX-Sz", "Фото та відео" },
                    { "ldXL58W6Omk", "Комп’ютери та ноутбуки" },
                    { "o1u-GOvZKyR", "Ігрова техніка" },
                    { "qStHAyFX8wZ", "Мультимедіа" },
                    { "sr5c_rppUYW", "Побутова техніка" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "GlobalCategoryId", "Name", "Priority", "ProductId" },
                values: new object[] { "1qLHSrWe_ot", null, "1JegB5Au-fY", "tablets.webp", 1, null });

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "GlobalCategoryId", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8075), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1JegB5Au-fY", false, "Смартфони" },
                    { "EZqnScP4oOP", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8103), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1JegB5Au-fY", false, "Аксесуари для смартфонів і планшетів" },
                    { "q9vxN1lqU-U", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8090), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1JegB5Au-fY", false, "Планшети" },
                    { "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(7970), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "ldXL58W6Omk", false, "Ноутбуки, ультрабуки та мінібуки" },
                    { "RXYxs8ws8U1", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8115), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "ldXL58W6Omk", false, "настільні ПК" },
                    { "Stc-d-qSMoI", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8134), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "ldXL58W6Omk", false, "монітори" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "GlobalCategoryId", "Name", "Priority", "ProductId" },
                values: new object[,]
                {
                    { "JuFaQapTYEj", "EnDKUD--DDw", null, "telephones.webp", 1, null },
                    { "wgWA9d1jmyr", "rlCbxfOimxf", "ldXL58W6Omk", "laptops.webp", 1, null }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Metric", "Name", "PublicName" },
                values: new object[,]
                {
                    { "3iG_LM_h0nx", "rlCbxfOimxf", null, "GraphicCard", "Дискретна відеокарта" },
                    { "a9KOQioORVn", "rlCbxfOimxf", null, "Processor", "Процесор" },
                    { "DLVkSB4M3_B", "rlCbxfOimxf", "ГБ", "RAM", "Обсяг оперативної пам'яті" },
                    { "eJrCKtjDVr3", "EnDKUD--DDw", "мА·год", "BatteryCapacity", "Ємність акумулятора" },
                    { "YJZiYQEbE5n", "EnDKUD--DDw", "\"", "DisplayDiagonal", "Діагональ екрана" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription", "UserLikeId" },
                values: new object[,]
                {
                    { "1QFg0DuM4tp", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9590), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 10.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", null },
                    { "3L6kQMzUed6", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9700), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Lenovo IdeaPad 5 Pro 16ACH6", 29999, "AMD Ryzen 7", 2.0, "Екран 16\" IPS (2560x1600) WQXGA, матовий / AMD Ryzen 7 5800H (3.2 - 4.4 ГГц) / RAM 16 ГБ / SSD 512 ГБ / NVIDIA GeForce RTX 3050, 4 ГБ / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 2.2 кг / сірий", null },
                    { "3UxuGnnHlIu", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9716), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 1.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", null },
                    { "51gkOL36kI-", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9582), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 11.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", null }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[] { "5k8VoF-dG7n", "q9vxN1lqU-U", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", 0, "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna", null });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[] { "aKwqGBZLXNA", 4100, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9803), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", null });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[] { "AOg0gOR_nFF", "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8349), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", 0, "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna", null });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription", "UserLikeId" },
                values: new object[,]
                {
                    { "B4ef_hPoAZd", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9709), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 3.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 8 ГБ / SSD 128 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", null },
                    { "bA3gr22xBnY", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9693), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "Intel Iris Xe Graphics", false, "Ноутбук HP Pavilion 15-cs3006ur Natural Silver", 23999, "Intel Core i5", 16.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / Intel Core i5-1135G7 (2.4 - 4.2 ГГц) / RAM 8 ГБ / SSD 256 ГБ / Intel Iris Xe Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 1.75 кг / сріблястий", null }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[,]
                {
                    { "cfsb0_yfU-s", 5000, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9879), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.8099999999999996, false, "Мобільний телефон Xiaomi Mi 12", 39999, "Екран (6.81\", OLED, 3200x1440) / Qualcomm Snapdragon 8 Gen 1 / основна квадро-камера: 50 Мп + 12 Мп + 8 Мп + 2 Мп, фронтальна камера: 32 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Dual SIM / Android 12", null },
                    { "cW8mEdX69oO", 4000, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9886), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.0999999999999996, false, "Мобільний телефон Samsung Galaxy S22", 45999, "Екран (6.1\", Dynamic AMOLED 2X, 1080x2400) / Samsung Exynos 2200 / основна квадро-камера: 50 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 10 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12", null },
                    { "D5gbCXTfyLT", 4900, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9835), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", null }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[] { "DCjMzJ-fOUh", "RXYxs8ws8U1", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8396), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", 0, "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna", null });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[,]
                {
                    { "hCK3ReredZ8", 4800, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9827), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", null },
                    { "Iwl-MnDxAzC", 3600, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9812), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", null }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[] { "JehDiTTOqS9", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8296), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", 0, "ProductEntity", false, "ПК Х123434", 436765, "figna", null });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[,]
                {
                    { "L3u_oaaLAmQ", 4200, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9845), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", null },
                    { "lT14V2S-Y5i", 3900, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9821), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", null },
                    { "mhkfEpBBWpF", 4500, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9861), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2000000000000002, false, "Мобільний телефон Google Pixel 7", 32999, "Екран (6.2\", OLED, 2400x1080) / Qualcomm Snapdragon 778G / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / eSIM / Android 12", null }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription", "UserLikeId" },
                values: new object[,]
                {
                    { "MqATwx9ixm1", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9597), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 12.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", null },
                    { "NLGDd--V_h2", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9608), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", null },
                    { "OcWrbSZLVhI", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9684), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", null }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[] { "pUfpDAblV_R", "EZqnScP4oOP", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8380), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", 0, "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna", null });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription", "UserLikeId" },
                values: new object[] { "Sz5C1kWnIgU", "rlCbxfOimxf", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9564), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 7.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", null });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[] { "TztEFnBXb-j", 4600, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9853), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", null });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[] { "vkczFrGII6o", "Stc-d-qSMoI", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Utc).AddTicks(8408), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", 0, "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna", null });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription", "UserLikeId" },
                values: new object[,]
                {
                    { "zc78GMhVxs5", 3100, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9795), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", null },
                    { "zSHHW9CUEQA", 5000, "EnDKUD--DDw", new DateTime(2023, 9, 11, 13, 34, 47, 5, DateTimeKind.Local).AddTicks(9869), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.5, false, "Мобільний телефон Sony Xperia 1 IV", 74999, "Екран (6.5\", OLED, 3840x1644) / Qualcomm Snapdragon 888 / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 10 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12", null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "GlobalCategoryId", "Name", "Priority", "ProductId" },
                values: new object[,]
                {
                    { "_AFUrP1UXmq", null, null, "2_3.webp", 3, "NLGDd--V_h2" },
                    { "_cvFEF7540f", null, null, "4_2.webp", 2, "aKwqGBZLXNA" },
                    { "_yr9OzBSAyI", null, null, "1_3.webp", 3, "MqATwx9ixm1" },
                    { "0ulejF6L1OD", null, null, "3_3.webp", 3, "mhkfEpBBWpF" },
                    { "0yxPoSTQZ9C", null, null, "2_2.webp", 2, "3L6kQMzUed6" },
                    { "1W3C5zrakHd", null, null, "1_3.webp", 3, "bA3gr22xBnY" },
                    { "44ZG4jV3ThV", null, null, "6_2.webp", 2, "lT14V2S-Y5i" },
                    { "4kBd9nfcZ8u", null, null, "6_3.webp", 3, "TztEFnBXb-j" },
                    { "5QcUGAawzI0", null, null, "6_1.webp", 1, "lT14V2S-Y5i" },
                    { "75kVmm32xk9", null, null, "2_2.webp", 2, "51gkOL36kI-" },
                    { "79zmA_K9eUT", null, null, "1_2.webp", 2, "3UxuGnnHlIu" },
                    { "7ELLGaRxBpp", null, null, "5_3.webp", 3, "L3u_oaaLAmQ" },
                    { "7KgSl5kCFkd", null, null, "4_1.webp", 1, "aKwqGBZLXNA" },
                    { "87EOAKuevdq", null, null, "3_1.webp", 1, "OcWrbSZLVhI" },
                    { "bd6c_LLR6Ct", null, null, "3_3.webp", 3, "OcWrbSZLVhI" },
                    { "BF_VmWzEAyc", null, null, "3_2.webp", 2, "B4ef_hPoAZd" },
                    { "BhebOQBGJ24", null, null, "3_2.webp", 2, "hCK3ReredZ8" },
                    { "BI4mHMIvpte", null, null, "2_1.webp", 1, "51gkOL36kI-" },
                    { "bInjMsy9fxk", null, null, "3_1.webp", 1, "hCK3ReredZ8" },
                    { "CqcwpxJtNvN", null, null, "4_2.webp", 2, "D5gbCXTfyLT" },
                    { "DgTMtNMCp3q", null, null, "1_1.webp", 1, "Sz5C1kWnIgU" },
                    { "dtWrC47MEI2", null, null, "3_3.webp", 3, "B4ef_hPoAZd" },
                    { "E3gnRP03RlO", null, null, "5_2.webp", 2, "cfsb0_yfU-s" },
                    { "EKVAASVqwQg", null, null, "6_2.webp", 2, "cW8mEdX69oO" },
                    { "f028cwAgs6R", null, null, "3_3.webp", 3, "zc78GMhVxs5" },
                    { "fBq9vJ5HiXL", null, null, "5_3.webp", 3, "Iwl-MnDxAzC" },
                    { "fLOYH02fEZD", null, null, "6_2.webp", 2, "TztEFnBXb-j" },
                    { "FsoxT9dA7JC", null, null, "1_3.webp", 3, "Sz5C1kWnIgU" },
                    { "FvRO_GfyU_V", null, null, "4_1.webp", 1, "D5gbCXTfyLT" },
                    { "gjmH3GooWof", null, null, "5_2.webp", 2, "Iwl-MnDxAzC" },
                    { "IWhWP5RYhwy", null, null, "5_1.webp", 1, "cfsb0_yfU-s" },
                    { "IZmoes1Bevn", null, null, "3_1.webp", 1, "B4ef_hPoAZd" },
                    { "j898esSxJXa", null, null, "2_3.webp", 3, "3L6kQMzUed6" },
                    { "JlE3uH_p0VT", null, null, "3_2.webp", 2, "mhkfEpBBWpF" },
                    { "kYnLCuU-ZPU", null, null, "1_2.webp", 2, "MqATwx9ixm1" },
                    { "l-QFRXgCdHi", null, null, "5_3.webp", 3, "cfsb0_yfU-s" },
                    { "L-s8mBhBjFm", null, null, "3_2.webp", 2, "OcWrbSZLVhI" },
                    { "LJa0-80JtpH", null, null, "1_1.webp", 1, "bA3gr22xBnY" },
                    { "LuGvxcyGLmx", null, null, "3_3.webp", 3, "1QFg0DuM4tp" },
                    { "M3hNs4yZOHr", null, null, "1_2.webp", 2, "Sz5C1kWnIgU" },
                    { "M6rTRpj_CzJ", null, null, "3_2.webp", 2, "1QFg0DuM4tp" },
                    { "M9AruxrQ2XL", null, null, "5_1.webp", 1, "Iwl-MnDxAzC" },
                    { "nbQyfVdLnR5", null, null, "4_2.webp", 2, "zSHHW9CUEQA" },
                    { "njG--lPUvDA", null, null, "1_3.webp", 3, "3UxuGnnHlIu" },
                    { "OGBy8DAa5NN", null, null, "2_2.webp", 2, "NLGDd--V_h2" },
                    { "OzwBY7fDgZF", null, null, "5_2.webp", 2, "L3u_oaaLAmQ" },
                    { "p2Xeszpl_fp", null, null, "1_1.webp", 1, "3UxuGnnHlIu" },
                    { "pF8TjYwD3CA", null, null, "2_1.webp", 1, "NLGDd--V_h2" },
                    { "QIqaFk9KyHu", null, null, "6_3.webp", 3, "cW8mEdX69oO" },
                    { "R76ITeawW0b", null, null, "3_3.webp", 3, "hCK3ReredZ8" },
                    { "rlzbVcJ3y6r", null, null, "4_3.webp", 3, "zSHHW9CUEQA" },
                    { "rQN0U0hPn_a", null, null, "5_1.webp", 1, "L3u_oaaLAmQ" },
                    { "s5fZWLoKO7S", null, null, "3_1.webp", 1, "1QFg0DuM4tp" },
                    { "sBlU5bPRRDf", null, null, "3_1.webp", 1, "mhkfEpBBWpF" },
                    { "Sm_c8cRsFH1", null, null, "6_3.webp", 3, "lT14V2S-Y5i" },
                    { "snXWoGJpz7m", null, null, "1_2.webp", 2, "bA3gr22xBnY" },
                    { "sRywdkwy6fq", null, null, "2_1.webp", 1, "3L6kQMzUed6" },
                    { "ssWEKPfne8g", null, null, "2_3.webp", 3, "51gkOL36kI-" },
                    { "TIE82aSlg85", null, null, "4_3.webp", 3, "aKwqGBZLXNA" },
                    { "tkExfuaZeHi", null, null, "6_1.webp", 1, "cW8mEdX69oO" },
                    { "UH4WVpvXcy3", null, null, "4_1.webp", 1, "zSHHW9CUEQA" },
                    { "un-nVZQhqAP", null, null, "3_2.webp", 2, "zc78GMhVxs5" },
                    { "X2AMYFO3fzc", null, null, "3_1.webp", 1, "zc78GMhVxs5" },
                    { "Y7vCTn0-Lpc", null, null, "1_1.webp", 1, "MqATwx9ixm1" },
                    { "y9kt3awnngO", null, null, "6_1.webp", 1, "TztEFnBXb-j" },
                    { "ZBN8dcKu9sv", null, null, "4_3.webp", 3, "D5gbCXTfyLT" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "MaxValue", "MinValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "2T9AByl9OsY", "eJrCKtjDVr3", 3999.0, 3000.0, "3000 - 3999 мА*год ", null },
                    { "7qZnE8Mg-oZ", "3iG_LM_h0nx", 0.0, 0.0, "GeForce RTX 3050", "RTX 3050" },
                    { "bueQnEQCdbF", "DLVkSB4M3_B", 12.0, 10.0, "10 - 12 ГБ", null },
                    { "de20fQwSREw", "DLVkSB4M3_B", 3.0, 0.20000000000000001, "3 ГБ і менше", null },
                    { "evQeHNhRKfc", "a9KOQioORVn", 0.0, 0.0, "Intel Core i5", "Intel Core i5" },
                    { "GOiB70U5J90", "3iG_LM_h0nx", 0.0, 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "iE1lE6S1lSK", "YJZiYQEbE5n", 5.5, 5.0099999999999998, "5.01\" - 5.5\"", null },
                    { "j2mFohAX3qY", "eJrCKtjDVr3", 4999.0, 4000.0, "4000 - 4999 мА*год ", null },
                    { "K2lqPIgmadm", "DLVkSB4M3_B", 8.0, 6.0, "6 - 8 ГБ", null },
                    { "LklOA26BTyD", "a9KOQioORVn", 0.0, 0.0, "Intel Core i7", "Intel Core i7" },
                    { "oqaxcgB4QSL", "a9KOQioORVn", 0.0, 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "pNtmsLMHjLk", "DLVkSB4M3_B", 24.0, 16.0, "16 - 24 ГБ", null },
                    { "Qasj8xrPgm5", "YJZiYQEbE5n", 5.0, 4.5999999999999996, "4.6\" - 5\"", null },
                    { "qv_h0VleFuo", "3iG_LM_h0nx", 0.0, 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "VNa9GHjEY5S", "DLVkSB4M3_B", 4.0, 4.0, "4 ГБ", null },
                    { "wCXObDLahXB", "YJZiYQEbE5n", 6.0, 5.5, "5.5\" - 6\"", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CategoryId",
                table: "Images",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_GlobalCategoryId",
                table: "Images",
                column: "GlobalCategoryId",
                unique: true,
                filter: "[GlobalCategoryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Adresses_UserId",
                table: "tbl_Adresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_cartItem_CartId",
                table: "tbl_cartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Categories_GlobalCategoryId",
                table: "tbl_Categories",
                column: "GlobalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FilterNames_CategoryId",
                table: "tbl_FilterNames",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FilterValues_FilterNameId",
                table: "tbl_FilterValues",
                column: "FilterNameId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Products_CategoryId",
                table: "tbl_Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Products_UserLikeId",
                table: "tbl_Products",
                column: "UserLikeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Reviews_AuthorId",
                table: "tbl_Reviews",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Reviews_ProductId",
                table: "tbl_Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tokens_SmartUserId",
                table: "tbl_Tokens",
                column: "SmartUserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "tbl_Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "tbl_Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "tbl_Adresses");

            migrationBuilder.DropTable(
                name: "tbl_cartItem");

            migrationBuilder.DropTable(
                name: "tbl_FilterValues");

            migrationBuilder.DropTable(
                name: "tbl_Reviews");

            migrationBuilder.DropTable(
                name: "tbl_Tokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "tbl_cart");

            migrationBuilder.DropTable(
                name: "tbl_FilterNames");

            migrationBuilder.DropTable(
                name: "tbl_Products");

            migrationBuilder.DropTable(
                name: "tbl_Categories");

            migrationBuilder.DropTable(
                name: "tbl_Users");

            migrationBuilder.DropTable(
                name: "tbl_GlobalCategories");
        }
    }
}
