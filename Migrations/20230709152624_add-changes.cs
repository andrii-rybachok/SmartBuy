using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class addchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_tbl_Users_SmartUserId",
                table: "Tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tokens",
                table: "Tokens");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "xVy4OSXHvGh");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "12es6thaYu0");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "ayekDZaosnQ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "lBrLVbFmFV-");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "qCW7QNq7oa7");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "rVqMMFOr9YZ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Yp6nng1-KM5");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "1WtkcSXrF6v");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "3lsMFnrD5Yy");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "bWV5f8oZq0u");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "qvTtGfOz7VW");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "UC2GZPYT1wB");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "Xf6WnWV_-7P");

            migrationBuilder.RenameTable(
                name: "Tokens",
                newName: "tbl_Tokens");

            migrationBuilder.RenameIndex(
                name: "IX_Tokens_SmartUserId",
                table: "tbl_Tokens",
                newName: "IX_tbl_Tokens_SmartUserId");

            migrationBuilder.AddColumn<string>(
                name: "PublicValue",
                table: "tbl_FilterValues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Tokens",
                table: "tbl_Tokens",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tokens_tbl_Users_SmartUserId",
                table: "tbl_Tokens",
                column: "SmartUserId",
                principalTable: "tbl_Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tokens_tbl_Users_SmartUserId",
                table: "tbl_Tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Tokens",
                table: "tbl_Tokens");

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

            migrationBuilder.DropColumn(
                name: "PublicValue",
                table: "tbl_FilterValues");

            migrationBuilder.RenameTable(
                name: "tbl_Tokens",
                newName: "Tokens");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Tokens_SmartUserId",
                table: "Tokens",
                newName: "IX_Tokens_SmartUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tokens",
                table: "Tokens",
                column: "Id");

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "1WtkcSXrF6v", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6265), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" },
                    { "3lsMFnrD5Yy", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6208), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { "bWV5f8oZq0u", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6271), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "qvTtGfOz7VW", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6268), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" },
                    { "UC2GZPYT1wB", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6276), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { "Xf6WnWV_-7P", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6261), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" },
                    { "xVy4OSXHvGh", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "12es6thaYu0", "qvTtGfOz7VW", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6358), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", false, "Bosch UniversalChain 40", 3958, "figna" },
                    { "ayekDZaosnQ", "UC2GZPYT1wB", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6391), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" },
                    { "lBrLVbFmFV-", "Xf6WnWV_-7P", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6349), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" },
                    { "qCW7QNq7oa7", "bWV5f8oZq0u", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6387), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" },
                    { "rVqMMFOr9YZ", "1WtkcSXrF6v", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6354), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", false, "BEKO CNA295K20XP", 10999, "figna" },
                    { "Yp6nng1-KM5", "3lsMFnrD5Yy", new DateTime(2023, 7, 9, 15, 59, 41, 936, DateTimeKind.Utc).AddTicks(6341), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", false, "ПК Х123434", 436765, "figna" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_tbl_Users_SmartUserId",
                table: "Tokens",
                column: "SmartUserId",
                principalTable: "tbl_Users",
                principalColumn: "Id");
        }
    }
}
