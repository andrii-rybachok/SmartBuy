using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class addlaptoptelephone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "pbd_PKkpdUI");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "0hePeDArB2I");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "6LLuIdJ8OCE");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Bdm-0ix3BXU");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "FMtOORjyWzP");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "l5rlgeM7Hqm");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "su30_wiVpKN");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "gV0nPuq41bi");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "krXGtCKoRF4");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "O28FT_7C6gz");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "o4V8-yCvIN6");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "Op72jBHPRvV");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "s30ClEaYITa");

            migrationBuilder.AddColumn<int>(
                name: "BatteryCapacity",
                table: "tbl_Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "tbl_Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "DisplayDiagonal",
                table: "tbl_Products",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GraphicCard",
                table: "tbl_Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Processor",
                table: "tbl_Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "e_6hvI6stRf", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4676), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" },
                    { "h3zqBJjNnN1", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4686), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { "imwccWSupND", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4608), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { "P1VxJlSTS_J", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4680), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "q01B9XSzO7u", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4689), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" },
                    { "r0HHeNteua_", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4667), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" },
                    { "sLeo04PkfFB", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4671), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "GlgpC9iRmPg", "e_6hvI6stRf", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4825), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" },
                    { "NkNp_HlpUVb", "h3zqBJjNnN1", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4833), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" },
                    { "obsHt7jAbxE", "imwccWSupND", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4809), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "ProductEntity", false, "ПК Х123434", 436765, "figna" },
                    { "pLN08ZDb3im", "sLeo04PkfFB", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4820), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" },
                    { "s9ZEVypPBYV", "r0HHeNteua_", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4816), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" },
                    { "wxFFIrerH11", "P1VxJlSTS_J", new DateTime(2023, 7, 9, 18, 23, 7, 77, DateTimeKind.Utc).AddTicks(4828), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "q01B9XSzO7u");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "GlgpC9iRmPg");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "NkNp_HlpUVb");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "obsHt7jAbxE");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "pLN08ZDb3im");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "s9ZEVypPBYV");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "wxFFIrerH11");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "e_6hvI6stRf");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "h3zqBJjNnN1");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "imwccWSupND");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "P1VxJlSTS_J");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "r0HHeNteua_");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "sLeo04PkfFB");

            migrationBuilder.DropColumn(
                name: "BatteryCapacity",
                table: "tbl_Products");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "tbl_Products");

            migrationBuilder.DropColumn(
                name: "DisplayDiagonal",
                table: "tbl_Products");

            migrationBuilder.DropColumn(
                name: "GraphicCard",
                table: "tbl_Products");

            migrationBuilder.DropColumn(
                name: "Processor",
                table: "tbl_Products");

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "gV0nPuq41bi", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(3920), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" },
                    { "krXGtCKoRF4", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(3923), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "O28FT_7C6gz", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(3912), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" },
                    { "o4V8-yCvIN6", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(3862), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { "Op72jBHPRvV", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(3917), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" },
                    { "pbd_PKkpdUI", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(3960), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" },
                    { "s30ClEaYITa", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(3929), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "0hePeDArB2I", "O28FT_7C6gz", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(4038), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" },
                    { "6LLuIdJ8OCE", "s30ClEaYITa", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(4054), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" },
                    { "Bdm-0ix3BXU", "krXGtCKoRF4", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(4050), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" },
                    { "FMtOORjyWzP", "o4V8-yCvIN6", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(4032), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", false, "ПК Х123434", 436765, "figna" },
                    { "l5rlgeM7Hqm", "gV0nPuq41bi", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(4046), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", false, "Bosch UniversalChain 40", 3958, "figna" },
                    { "su30_wiVpKN", "Op72jBHPRvV", new DateTime(2023, 7, 9, 17, 55, 23, 873, DateTimeKind.Utc).AddTicks(4043), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", false, "BEKO CNA295K20XP", 10999, "figna" }
                });
        }
    }
}
