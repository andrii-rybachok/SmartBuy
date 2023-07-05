using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class productAndCategory_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastEdit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastEdit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8337), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { 2, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8429), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" },
                    { 3, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8435), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" },
                    { 4, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8440), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" },
                    { 5, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8444), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { 6, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8454), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { 7, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8459), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8595), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "1.jpg", false, "ПК Х123434", 436765, "figna" },
                    { 2, 2, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8606), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", "1.jpg", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" },
                    { 3, 3, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8611), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", "1.jpg", false, "BEKO CNA295K20XP", 10999, "figna" },
                    { 4, 4, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8616), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", "1.jpg", false, "Bosch UniversalChain 40", 3958, "figna" },
                    { 5, 5, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8620), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", "1.jpg", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" },
                    { 6, 6, new DateTime(2023, 7, 5, 12, 54, 7, 653, DateTimeKind.Utc).AddTicks(8625), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", "1.jpg", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Products_CategoryId",
                table: "tbl_Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Products");

            migrationBuilder.DropTable(
                name: "tbl_Categories");
        }
    }
}
