using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class addfiltervalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "z4KqEICtncD");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "5vu5pFD0EZi");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "72Nt27oGxYt");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "7R-W5eNIRCo");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "boZhk8N4-ms");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "iA2Ng90f8xC");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Wn4iQyWrIqT");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "1PgA5OcFLRI");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "ek6jbbqDp59");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "Hb9brPC_X-J");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "n5fZ2t4jnXl");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "o5XM9CF7hLZ");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "S8zdJam10lk");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "tbl_FilterValues",
                newName: "StringValue");

            migrationBuilder.AddColumn<double>(
                name: "NumericValue",
                table: "tbl_FilterValues",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "NumericValue",
                table: "tbl_FilterValues");

            migrationBuilder.RenameColumn(
                name: "StringValue",
                table: "tbl_FilterValues",
                newName: "Value");

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "1PgA5OcFLRI", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9569), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { "ek6jbbqDp59", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9534), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" },
                    { "Hb9brPC_X-J", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" },
                    { "n5fZ2t4jnXl", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "o5XM9CF7hLZ", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9470), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { "S8zdJam10lk", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9520), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" },
                    { "z4KqEICtncD", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9573), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "5vu5pFD0EZi", "o5XM9CF7hLZ", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9638), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", false, "ПК Х123434", 436765, "figna" },
                    { "72Nt27oGxYt", "ek6jbbqDp59", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9655), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", false, "Bosch UniversalChain 40", 3958, "figna" },
                    { "7R-W5eNIRCo", "S8zdJam10lk", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" },
                    { "boZhk8N4-ms", "Hb9brPC_X-J", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9650), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", false, "BEKO CNA295K20XP", 10999, "figna" },
                    { "iA2Ng90f8xC", "n5fZ2t4jnXl", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9658), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" },
                    { "Wn4iQyWrIqT", "1PgA5OcFLRI", new DateTime(2023, 7, 9, 17, 26, 23, 953, DateTimeKind.Utc).AddTicks(9662), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" }
                });
        }
    }
}
