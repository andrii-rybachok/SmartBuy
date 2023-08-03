using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class addedglobalcategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_tbl_Products_ProductId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_tbl_Users_AuthorId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "_FNzxqCNp7K");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "_WUylZTdFYi");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "_yvPsaiG6Po");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "-14_T4Dy30Z");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "-8SlXTY3yDM");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "-9eUdGrVOMB");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "3BrgOOrgre-");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "3C0DRy_cX0P");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "3gLET18XpTs");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "4SFBtLq5viS");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "4Z9sgyMNs6u");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "62uxfBRdyFP");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "6mQ-3JubbuZ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "7519HsWdxKl");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "A8xGCuNRbjn");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "aGfirM1Wzc7");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "ARWg3UE57pu");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "aweiCkmnH_1");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "BuLPNjYEg9j");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "cDYFRP3-C1l");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "EIdYfjqlz2N");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "EJ-YL0B1-JH");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "EOMteIBMaig");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "eqvM75n6Dn-");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "FupLBhtNjzA");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "Gf70RTii9ix");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "ghLVd_uQmpL");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "GpDqScEkzQG");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "hm1QRAmIuHQ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "HSXmaEzvGLX");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "I8FRiZBSBl8");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "iCqV7xyGPMZ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "IJ72q1xPu8t");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "IMW1bNTS8lo");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "jb8AAmuzDFb");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "jjiq3UjCgFH");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "kiZCzRXJp7p");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "kt5S5wK4jGC");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "l34f2H2hXAW");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "lExeXyvAXuZ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "lNrUNwiMWmI");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "m5GZbOf9fiJ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "MhcK3eF7OHo");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "NG1zpHYZ0Xn");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "ogio62nScrz");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "OsWXYlyyQ94");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "oY0q9N8_1_O");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "P5tJuHgrYrp");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "qccgozSGWad");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "QeDnXHapWOd");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "QPCOQet9_9D");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "qY4jAsqQhYe");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "RAJ3lRA7J_i");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "RBEKn9vERqJ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "rSduYBVJIwt");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "SFlcLEvyA3_");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "SoEJo8ocFqH");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "soYNUXXfkDS");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "TSS-WbPbFg3");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "U1NCHm6YY9D");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "UTHaG2pwFgQ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "VoPUZEv-U8f");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "X-aefPJKkRG");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "XmwYFGndg1P");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "ZGvSwiLl39q");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "zuKoiIaCUWj");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "Zx2XCKAOaOa");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "zZD1l6pSTtK");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "by_54PlTU0J");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "2OkofcctUQD");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "7Vh1_TRtgK2");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "Ag8RAQkmwTa");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "F_MWfKPGlX1");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "FPhqc1Ct8nQ");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "hdKwd0W0BUy");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "HWXG1Ogpi0i");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "IPy68WU4Bbo");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "lw6O2M1Dn59");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "mi6UU02hZ60");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "MLHgKjCmu1S");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "mYGRrUARH6g");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "O4LnA_cxjF3");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "pbRo71Cz7EN");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "R-oqCtNIqPu");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "ur6KI9q2SC-");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "127EzjPLMTz");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "641wfcwa4DZ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "D9pNRsCvdcD");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "EZY488FLDnT");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "k3KQCstxIXG");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "MOTI1q2qbqq");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "94lAOdl0QWy");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "CXD8b7gn5mg");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "kmoSrFBAE2q");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "XTmQOR7aNsG");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "79Xa4Z4OW9m");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "a4ftuWBbKi7");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "H4FLS7bDoyL");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "mRX96bFOXhr");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "tlh3NxncHJc");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "55LcIJu2KpP");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "6xNhyanBp7i");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "938kYMQ6YD_");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "9aqWnqAwPmq");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "9maYYCTeCU-");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "AB9dPMRxx2l");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "DaQ5_0nnthZ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "DyhZ-Qm3RUe");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "GnLcBELByjy");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "HAJ--QhNcHt");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "jl5r0PmjfFJ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Jzfx_EpnZOP");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "O5JrjbFj983");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "PZVWjYvMdHP");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "QXFjRrimIZD");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "SkHRhpGZYxa");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "so4b0EsnwD3");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "uTy0b5fjlBN");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "uzAmcyIr-pr");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "vLss89S6Atc");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "wZttGY5B8sb");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "ZjgCVOUZ6mE");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "JFMwotDdZNz");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "Ypzpp28bZSi");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "tbl_Reviews");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ProductId",
                table: "tbl_Reviews",
                newName: "IX_tbl_Reviews_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AuthorId",
                table: "tbl_Reviews",
                newName: "IX_tbl_Reviews_AuthorId");

            migrationBuilder.AddColumn<string>(
                name: "GlobalCategoryId",
                table: "tbl_Categories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GlobalCategoryId",
                table: "Images",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Reviews",
                table: "tbl_Reviews",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "tbl_GlobalCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "11voIk1zZ8L", "Електро-інструменти" },
                    { "6Ay12aVmK9_", "Смартфони та планшети" },
                    { "B_rcMQDhW5e", "Ігрова техніка" },
                    { "C1hL39XT6CC", "Фото та відео" },
                    { "EQW85ud0jHK", "Комп’ютери та ноутбуки" },
                    { "iAfFWWdQKP1", "Електронні гаджети" },
                    { "iiAz1riArCs", "Аудіо" },
                    { "lexaIgWrwWl", "Мультимедіа" },
                    { "wlNv-v0gRe0", "Побутова техніка" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "GlobalCategoryId", "Name", "Priority", "ProductId" },
                values: new object[] { "ELwn8bQMnYB", null, "6Ay12aVmK9_", "tablets.webp", 1, null });

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "GlobalCategoryId", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(329), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "EQW85ud0jHK", false, "Ноутбуки, ультрабуки та мінібуки" },
                    { "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(385), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "6Ay12aVmK9_", false, "Смартфони" },
                    { "hS3Q4cswxQF", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(393), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "6Ay12aVmK9_", false, "Аксесуари для смартфонів і планшетів" },
                    { "KqtiMYqLmPM", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(402), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "EQW85ud0jHK", false, "монітори" },
                    { "RWi0n1LSY78", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(389), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "6Ay12aVmK9_", false, "Планшети" },
                    { "xzghLbBDo_L", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(397), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "EQW85ud0jHK", false, "настільні ПК" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "GlobalCategoryId", "Name", "Priority", "ProductId" },
                values: new object[,]
                {
                    { "lw_SiOUMDES", "2x43aWgcHYA", "EQW85ud0jHK", "laptops.webp", 1, null },
                    { "XExNfr5sseW", "chqGu4Sgvtp", null, "telephones.webp", 1, null }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Name", "PublicName" },
                values: new object[,]
                {
                    { "0sbxRcBZ8sR", "chqGu4Sgvtp", "DisplayDiagonal", "Діагональ екрана" },
                    { "FmYldjaqh7c", "2x43aWgcHYA", "Processor", "Процесор" },
                    { "hDlpSyfLypQ", "chqGu4Sgvtp", "BatteryCapacity", "Ємність акумулятора" },
                    { "joiWgyMV0cq", "2x43aWgcHYA", "RAM", "Обсяг оперативної пам'яті" },
                    { "YDbgdlwx90D", "2x43aWgcHYA", "GraphicCard", "Дискретна відеокарта" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "_ONAGJMdd-_", 4200, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(809), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "-SjwLdwfJKB", 4800, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(804), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "65Yyqp9ZSv-", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(749), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 1.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "6mX-a1qTc92", 4500, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(813), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2000000000000002, false, "Мобільний телефон Google Pixel 7", 32999, "Екран (6.2\", OLED, 2400x1080) / Qualcomm Snapdragon 778G / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / eSIM / Android 12" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[,]
                {
                    { "9DIEWTR2l8h", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(726), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 7.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "a3--wi_gaj_", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(735), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 12.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "AF_ceD3NM6N", "KqtiMYqLmPM", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(475), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", 0, "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" },
                    { "bwF-zEs_1z7", "RWi0n1LSY78", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(462), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", 0, "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "bX7kdvos81M", 5000, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(817), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.8099999999999996, false, "Мобільний телефон Xiaomi Mi 12", 39999, "Екран (6.81\", OLED, 3200x1440) / Qualcomm Snapdragon 8 Gen 1 / основна квадро-камера: 50 Мп + 12 Мп + 8 Мп + 2 Мп, фронтальна камера: 32 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Dual SIM / Android 12" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "D7LtTYt8Mt3", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(729), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 11.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "e2TP5-npkng", "xzghLbBDo_L", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(471), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", 0, "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[,]
                {
                    { "ejx_vPFD-wX", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(740), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "JER0N8qGY1H", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(746), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 3.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 8 ГБ / SSD 128 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "jR1wK4wi5qY", 4600, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "KvlRbbHcYvu", "hS3Q4cswxQF", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(466), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", 0, "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "obd8kWm0r-V", 4000, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(819), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.0999999999999996, false, "Мобільний телефон Samsung Galaxy S22", 45999, "Екран (6.1\", Dynamic AMOLED 2X, 1080x2400) / Samsung Exynos 2200 / основна квадро-камера: 50 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 10 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "OqrJdERhnkU", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(737), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "pv9kcr33642", 5000, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(815), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.5, false, "Мобільний телефон Sony Xperia 1 IV", 74999, "Екран (6.5\", OLED, 3840x1644) / Qualcomm Snapdragon 888 / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 10 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "Qdv3MZAC2m8", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(744), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Lenovo IdeaPad 5 Pro 16ACH6", 29999, "AMD Ryzen 7", 2.0, "Екран 16\" IPS (2560x1600) WQXGA, матовий / AMD Ryzen 7 5800H (3.2 - 4.4 ГГц) / RAM 16 ГБ / SSD 512 ГБ / NVIDIA GeForce RTX 3050, 4 ГБ / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 2.2 кг / сірий" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "r3s4x6aIqr8", 4100, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(798), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "SJJYpT02bzR", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(449), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", 0, "ProductEntity", false, "ПК Х123434", 436765, "figna" },
                    { "SU3WZuyQEuT", "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Utc).AddTicks(457), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", 0, "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "UFx2ZydHreu", 3600, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(800), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "vVZ19ZixG6z", 3900, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(801), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "xa6-JbJ5Oqh", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(732), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 10.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "YdDDo2cLvPQ", 3100, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(795), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "yECEFww8egh", "2x43aWgcHYA", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(742), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "Intel Iris Xe Graphics", false, "Ноутбук HP Pavilion 15-cs3006ur Natural Silver", 23999, "Intel Core i5", 16.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / Intel Core i5-1135G7 (2.4 - 4.2 ГГц) / RAM 8 ГБ / SSD 256 ГБ / Intel Iris Xe Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 1.75 кг / сріблястий" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "yHa9TkocjWU", 4900, "chqGu4Sgvtp", new DateTime(2023, 8, 2, 21, 8, 3, 976, DateTimeKind.Local).AddTicks(806), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "GlobalCategoryId", "Name", "Priority", "ProductId" },
                values: new object[,]
                {
                    { "_LI25oHxwBI", null, null, "4_2.webp", 2, "yHa9TkocjWU" },
                    { "_lW2jNK99so", null, null, "6_1.webp", 1, "vVZ19ZixG6z" },
                    { "-G6XI4_uTj-", null, null, "5_2.webp", 2, "UFx2ZydHreu" },
                    { "2LIxiAciDSt", null, null, "1_3.webp", 3, "a3--wi_gaj_" },
                    { "4S7sLudtEIE", null, null, "2_1.webp", 1, "Qdv3MZAC2m8" },
                    { "4yNsCYaxaeX", null, null, "3_1.webp", 1, "ejx_vPFD-wX" },
                    { "5xmYOr5-tqQ", null, null, "4_3.webp", 3, "r3s4x6aIqr8" },
                    { "6P6FqjvUA6B", null, null, "4_2.webp", 2, "pv9kcr33642" },
                    { "8Uyl6kDNsTq", null, null, "4_2.webp", 2, "r3s4x6aIqr8" },
                    { "9He979QmwWr", null, null, "2_1.webp", 1, "D7LtTYt8Mt3" },
                    { "9taf-mlDAUN", null, null, "2_1.webp", 1, "OqrJdERhnkU" },
                    { "a0M-LvsSNfI", null, null, "5_3.webp", 3, "bX7kdvos81M" },
                    { "bDY6kjZV-jz", null, null, "5_3.webp", 3, "UFx2ZydHreu" },
                    { "CF_MLePsdb_", null, null, "1_1.webp", 1, "65Yyqp9ZSv-" },
                    { "dAvbQIO47P4", null, null, "6_3.webp", 3, "obd8kWm0r-V" },
                    { "DLs9gIC-Rys", null, null, "3_3.webp", 3, "ejx_vPFD-wX" },
                    { "eA8JivLeie5", null, null, "3_3.webp", 3, "-SjwLdwfJKB" },
                    { "FyUah-ikGex", null, null, "3_2.webp", 2, "xa6-JbJ5Oqh" },
                    { "G_NOdDIzO83", null, null, "5_1.webp", 1, "_ONAGJMdd-_" },
                    { "G9a__FHjCOc", null, null, "3_1.webp", 1, "6mX-a1qTc92" },
                    { "GnxuDS7dHnQ", null, null, "2_2.webp", 2, "Qdv3MZAC2m8" },
                    { "hmCEjyF_oAK", null, null, "2_3.webp", 3, "OqrJdERhnkU" },
                    { "hqoMPkpQAeD", null, null, "6_1.webp", 1, "obd8kWm0r-V" },
                    { "ihLqPY5YSjx", null, null, "2_3.webp", 3, "D7LtTYt8Mt3" },
                    { "ILyTANVMwwB", null, null, "4_1.webp", 1, "r3s4x6aIqr8" },
                    { "J1slBtJaJX3", null, null, "2_2.webp", 2, "D7LtTYt8Mt3" },
                    { "J3OczAnOTAC", null, null, "3_3.webp", 3, "JER0N8qGY1H" },
                    { "jgi5FIy3hKQ", null, null, "1_2.webp", 2, "a3--wi_gaj_" },
                    { "jrVuxZEYXuW", null, null, "3_1.webp", 1, "-SjwLdwfJKB" },
                    { "Ju0yEgvRgj8", null, null, "4_1.webp", 1, "pv9kcr33642" },
                    { "LX4mjmNkfIt", null, null, "6_3.webp", 3, "jR1wK4wi5qY" },
                    { "MnkoEFRNwKI", null, null, "1_1.webp", 1, "yECEFww8egh" },
                    { "pjFaEfXMo6g", null, null, "6_1.webp", 1, "jR1wK4wi5qY" },
                    { "pSQNWikbOvF", null, null, "2_2.webp", 2, "OqrJdERhnkU" },
                    { "PycjjSjD42N", null, null, "3_2.webp", 2, "JER0N8qGY1H" },
                    { "qlBmlD3L2T2", null, null, "3_2.webp", 2, "-SjwLdwfJKB" },
                    { "QOdpEFkBkXg", null, null, "1_3.webp", 3, "65Yyqp9ZSv-" },
                    { "rAH6p7LUhS2", null, null, "1_1.webp", 1, "9DIEWTR2l8h" },
                    { "rTdiJxlkJuj", null, null, "1_3.webp", 3, "yECEFww8egh" },
                    { "SIb3yMBnlYC", null, null, "6_2.webp", 2, "vVZ19ZixG6z" },
                    { "StPqroDnuLZ", null, null, "4_1.webp", 1, "yHa9TkocjWU" },
                    { "T1TNJCKeyF3", null, null, "1_2.webp", 2, "65Yyqp9ZSv-" },
                    { "T8SoeN-Zdyh", null, null, "1_2.webp", 2, "9DIEWTR2l8h" },
                    { "tmUZKb2QlkG", null, null, "3_3.webp", 3, "YdDDo2cLvPQ" },
                    { "TOazO5mC_yk", null, null, "2_3.webp", 3, "Qdv3MZAC2m8" },
                    { "tZFiEHJEayf", null, null, "3_1.webp", 1, "xa6-JbJ5Oqh" },
                    { "uA6-hvbWBY-", null, null, "3_3.webp", 3, "6mX-a1qTc92" },
                    { "UAlg7cHVG2R", null, null, "3_1.webp", 1, "JER0N8qGY1H" },
                    { "vjh6mecgCVR", null, null, "3_2.webp", 2, "ejx_vPFD-wX" },
                    { "WeRCOGw3TNV", null, null, "6_2.webp", 2, "jR1wK4wi5qY" },
                    { "WinktwNIUrH", null, null, "3_1.webp", 1, "YdDDo2cLvPQ" },
                    { "WRGaafqLc7E", null, null, "1_1.webp", 1, "a3--wi_gaj_" },
                    { "WXlHgCH_cNB", null, null, "6_2.webp", 2, "obd8kWm0r-V" },
                    { "xDMLPNiRr7Y", null, null, "6_3.webp", 3, "vVZ19ZixG6z" },
                    { "XE2H1xJb4UM", null, null, "5_2.webp", 2, "bX7kdvos81M" },
                    { "xK7jBzjEbqW", null, null, "4_3.webp", 3, "pv9kcr33642" },
                    { "XPzz2xYsEnS", null, null, "5_2.webp", 2, "_ONAGJMdd-_" },
                    { "XwYdJ5CXzbm", null, null, "5_3.webp", 3, "_ONAGJMdd-_" },
                    { "YAAqUq8S2eG", null, null, "3_3.webp", 3, "xa6-JbJ5Oqh" },
                    { "yfXxDDv2RYs", null, null, "1_3.webp", 3, "9DIEWTR2l8h" },
                    { "YGfGoye52rg", null, null, "3_2.webp", 2, "6mX-a1qTc92" },
                    { "YHoutKNI0rQ", null, null, "3_2.webp", 2, "YdDDo2cLvPQ" },
                    { "yl14B9AuuTC", null, null, "5_1.webp", 1, "bX7kdvos81M" },
                    { "YRiyWnH5j_b", null, null, "5_1.webp", 1, "UFx2ZydHreu" },
                    { "z0ksCGWVKx6", null, null, "4_3.webp", 3, "yHa9TkocjWU" },
                    { "zwaaI2fygcH", null, null, "1_2.webp", 2, "yECEFww8egh" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "MaxValue", "MinValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "_PiCC3mq51k", "0sbxRcBZ8sR", 5.5, 5.0099999999999998, "5.01\" - 5.5\"", null },
                    { "0tIjMPT_50P", "FmYldjaqh7c", 0.0, 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "7lJVzh5BcWm", "0sbxRcBZ8sR", 5.0, 4.5999999999999996, "4.6\" - 5\"", null },
                    { "Dbtmhqq8ecX", "YDbgdlwx90D", 0.0, 0.0, "GeForce RTX 3050", "RTX 3050" },
                    { "eX34eBjLRdR", "joiWgyMV0cq", 4.0, 4.0, "4 ГБ", null },
                    { "f3_f536AHfs", "FmYldjaqh7c", 0.0, 0.0, "Intel Core i5", "Intel Core i5" },
                    { "g-vnCEyzAbH", "hDlpSyfLypQ", 3999.0, 3000.0, "3000 - 3999 мА*год ", null },
                    { "IkLYztfxnsz", "0sbxRcBZ8sR", 6.0, 5.5, "5.5\" - 6\"", null },
                    { "l0MlZ9bXdaj", "YDbgdlwx90D", 0.0, 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "R1gRH3bOmFH", "joiWgyMV0cq", 8.0, 6.0, "6 - 8 ГБ", null },
                    { "SwIZLdBKb1g", "YDbgdlwx90D", 0.0, 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "UVLK9fl4tcW", "joiWgyMV0cq", 12.0, 10.0, "10 - 12 ГБ", null },
                    { "w-szMHHST7T", "joiWgyMV0cq", 3.0, 0.20000000000000001, "3 ГБ і менше", null },
                    { "XUV4u3u9jOx", "FmYldjaqh7c", 0.0, 0.0, "Intel Core i7", "Intel Core i7" },
                    { "Y5SVCHmrCZQ", "hDlpSyfLypQ", 4999.0, 4000.0, "4000 - 4999 мА*год ", null },
                    { "zjcscmcZgbt", "joiWgyMV0cq", 24.0, 16.0, "16 - 24 ГБ", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Categories_GlobalCategoryId",
                table: "tbl_Categories",
                column: "GlobalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_GlobalCategoryId",
                table: "Images",
                column: "GlobalCategoryId",
                unique: true,
                filter: "[GlobalCategoryId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_tbl_GlobalCategories_GlobalCategoryId",
                table: "Images",
                column: "GlobalCategoryId",
                principalTable: "tbl_GlobalCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Categories_tbl_GlobalCategories_GlobalCategoryId",
                table: "tbl_Categories",
                column: "GlobalCategoryId",
                principalTable: "tbl_GlobalCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Reviews_tbl_Products_ProductId",
                table: "tbl_Reviews",
                column: "ProductId",
                principalTable: "tbl_Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Reviews_tbl_Users_AuthorId",
                table: "tbl_Reviews",
                column: "AuthorId",
                principalTable: "tbl_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_tbl_GlobalCategories_GlobalCategoryId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Categories_tbl_GlobalCategories_GlobalCategoryId",
                table: "tbl_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Reviews_tbl_Products_ProductId",
                table: "tbl_Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Reviews_tbl_Users_AuthorId",
                table: "tbl_Reviews");

            migrationBuilder.DropTable(
                name: "tbl_GlobalCategories");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Categories_GlobalCategoryId",
                table: "tbl_Categories");

            migrationBuilder.DropIndex(
                name: "IX_Images_GlobalCategoryId",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Reviews",
                table: "tbl_Reviews");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "_LI25oHxwBI");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "_lW2jNK99so");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "-G6XI4_uTj-");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "2LIxiAciDSt");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "4S7sLudtEIE");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "4yNsCYaxaeX");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "5xmYOr5-tqQ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "6P6FqjvUA6B");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "8Uyl6kDNsTq");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "9He979QmwWr");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "9taf-mlDAUN");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "a0M-LvsSNfI");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "bDY6kjZV-jz");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "CF_MLePsdb_");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "dAvbQIO47P4");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "DLs9gIC-Rys");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "eA8JivLeie5");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "ELwn8bQMnYB");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "FyUah-ikGex");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "G_NOdDIzO83");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "G9a__FHjCOc");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "GnxuDS7dHnQ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "hmCEjyF_oAK");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "hqoMPkpQAeD");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "ihLqPY5YSjx");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "ILyTANVMwwB");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "J1slBtJaJX3");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "J3OczAnOTAC");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "jgi5FIy3hKQ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "jrVuxZEYXuW");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "Ju0yEgvRgj8");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "lw_SiOUMDES");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "LX4mjmNkfIt");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "MnkoEFRNwKI");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "pjFaEfXMo6g");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "pSQNWikbOvF");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "PycjjSjD42N");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "qlBmlD3L2T2");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "QOdpEFkBkXg");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "rAH6p7LUhS2");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "rTdiJxlkJuj");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "SIb3yMBnlYC");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "StPqroDnuLZ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "T1TNJCKeyF3");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "T8SoeN-Zdyh");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "tmUZKb2QlkG");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "TOazO5mC_yk");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "tZFiEHJEayf");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "uA6-hvbWBY-");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "UAlg7cHVG2R");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "vjh6mecgCVR");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "WeRCOGw3TNV");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "WinktwNIUrH");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "WRGaafqLc7E");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "WXlHgCH_cNB");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "xDMLPNiRr7Y");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "XE2H1xJb4UM");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "XExNfr5sseW");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "xK7jBzjEbqW");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "XPzz2xYsEnS");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "XwYdJ5CXzbm");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "YAAqUq8S2eG");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "yfXxDDv2RYs");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "YGfGoye52rg");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "YHoutKNI0rQ");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "yl14B9AuuTC");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "YRiyWnH5j_b");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "z0ksCGWVKx6");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: "zwaaI2fygcH");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "_PiCC3mq51k");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "0tIjMPT_50P");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "7lJVzh5BcWm");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "Dbtmhqq8ecX");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "eX34eBjLRdR");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "f3_f536AHfs");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "g-vnCEyzAbH");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "IkLYztfxnsz");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "l0MlZ9bXdaj");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "R1gRH3bOmFH");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "SwIZLdBKb1g");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "UVLK9fl4tcW");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "w-szMHHST7T");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "XUV4u3u9jOx");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "Y5SVCHmrCZQ");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "zjcscmcZgbt");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "AF_ceD3NM6N");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "bwF-zEs_1z7");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "e2TP5-npkng");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "KvlRbbHcYvu");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "SJJYpT02bzR");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "SU3WZuyQEuT");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "hS3Q4cswxQF");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "KqtiMYqLmPM");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "RWi0n1LSY78");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "xzghLbBDo_L");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "0sbxRcBZ8sR");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "FmYldjaqh7c");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "hDlpSyfLypQ");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "joiWgyMV0cq");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "YDbgdlwx90D");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "_ONAGJMdd-_");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "-SjwLdwfJKB");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "65Yyqp9ZSv-");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "6mX-a1qTc92");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "9DIEWTR2l8h");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "a3--wi_gaj_");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "bX7kdvos81M");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "D7LtTYt8Mt3");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "ejx_vPFD-wX");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "JER0N8qGY1H");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "jR1wK4wi5qY");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "obd8kWm0r-V");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "OqrJdERhnkU");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "pv9kcr33642");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Qdv3MZAC2m8");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "r3s4x6aIqr8");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "UFx2ZydHreu");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "vVZ19ZixG6z");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "xa6-JbJ5Oqh");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "YdDDo2cLvPQ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "yECEFww8egh");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "yHa9TkocjWU");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "2x43aWgcHYA");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "chqGu4Sgvtp");

            migrationBuilder.DropColumn(
                name: "GlobalCategoryId",
                table: "tbl_Categories");

            migrationBuilder.DropColumn(
                name: "GlobalCategoryId",
                table: "Images");

            migrationBuilder.RenameTable(
                name: "tbl_Reviews",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Reviews_ProductId",
                table: "Comments",
                newName: "IX_Comments_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Reviews_AuthorId",
                table: "Comments",
                newName: "IX_Comments_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "94lAOdl0QWy", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(1897), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Дача, сад, город" },
                    { "by_54PlTU0J", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(1913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", false, "test" },
                    { "CXD8b7gn5mg", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(1851), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Побутова техніка" },
                    { "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(1797), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Комп'ютери та ноутбуки" },
                    { "kmoSrFBAE2q", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(1900), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Спорт і захоплення" },
                    { "XTmQOR7aNsG", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(1905), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Офіс, школа, книги" },
                    { "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(1847), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Смартфони" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "Name", "Priority", "ProductId" },
                values: new object[,]
                {
                    { "EJ-YL0B1-JH", "Ypzpp28bZSi", "5_1.webp", 1, null },
                    { "ogio62nScrz", "JFMwotDdZNz", "3_1.webp", 1, null }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Name", "PublicName" },
                values: new object[,]
                {
                    { "79Xa4Z4OW9m", "JFMwotDdZNz", "Processor", "Процесор" },
                    { "a4ftuWBbKi7", "JFMwotDdZNz", "RAM", "Обсяг оперативної пам'яті" },
                    { "H4FLS7bDoyL", "JFMwotDdZNz", "GraphicCard", "Дискретна відеокарта" },
                    { "mRX96bFOXhr", "Ypzpp28bZSi", "BatteryCapacity", "Ємність акумулятора" },
                    { "tlh3NxncHJc", "Ypzpp28bZSi", "DisplayDiagonal", "Діагональ екрана" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "127EzjPLMTz", "kmoSrFBAE2q", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(2031), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", 0, "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "55LcIJu2KpP", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2315), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 3.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 8 ГБ / SSD 128 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "641wfcwa4DZ", "XTmQOR7aNsG", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(2035), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", 0, "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "6xNhyanBp7i", 5000, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2393), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.5, false, "Мобільний телефон Sony Xperia 1 IV", 74999, "Екран (6.5\", OLED, 3840x1644) / Qualcomm Snapdragon 888 / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 10 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12" },
                    { "938kYMQ6YD_", 4100, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2376), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "9aqWnqAwPmq", 4900, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2384), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "9maYYCTeCU-", 4800, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2382), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "AB9dPMRxx2l", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2304), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 12.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "D9pNRsCvdcD", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(2010), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", 0, "ProductEntity", false, "ПК Х123434", 436765, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "DaQ5_0nnthZ", 4200, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2387), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "DyhZ-Qm3RUe", 4500, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2391), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2000000000000002, false, "Мобільний телефон Google Pixel 7", 32999, "Екран (6.2\", OLED, 2400x1080) / Qualcomm Snapdragon 778G / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / eSIM / Android 12" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "EZY488FLDnT", "CXD8b7gn5mg", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(2024), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", 0, "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "GnLcBELByjy", 4600, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2389), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "HAJ--QhNcHt", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2318), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 1.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "jl5r0PmjfFJ", 5000, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2395), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.8099999999999996, false, "Мобільний телефон Xiaomi Mi 12", 39999, "Екран (6.81\", OLED, 3200x1440) / Qualcomm Snapdragon 8 Gen 1 / основна квадро-камера: 50 Мп + 12 Мп + 8 Мп + 2 Мп, фронтальна камера: 32 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Dual SIM / Android 12" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "Jzfx_EpnZOP", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2301), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 11.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "k3KQCstxIXG", "94lAOdl0QWy", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(2027), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", 0, "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" },
                    { "MOTI1q2qbqq", "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Utc).AddTicks(2019), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", 0, "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "O5JrjbFj983", 4000, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2397), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.0999999999999996, false, "Мобільний телефон Samsung Galaxy S22", 45999, "Екран (6.1\", Dynamic AMOLED 2X, 1080x2400) / Samsung Exynos 2200 / основна квадро-камера: 50 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 10 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "PZVWjYvMdHP", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2297), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 7.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "QXFjRrimIZD", 3100, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2373), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "SkHRhpGZYxa", 3900, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2380), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "so4b0EsnwD3", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2311), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "Intel Iris Xe Graphics", false, "Ноутбук HP Pavilion 15-cs3006ur Natural Silver", 23999, "Intel Core i5", 16.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / Intel Core i5-1135G7 (2.4 - 4.2 ГГц) / RAM 8 ГБ / SSD 256 ГБ / Intel Iris Xe Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 1.75 кг / сріблястий" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "uTy0b5fjlBN", 3600, "Ypzpp28bZSi", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2378), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[,]
                {
                    { "uzAmcyIr-pr", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2309), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "vLss89S6Atc", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2306), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "wZttGY5B8sb", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2302), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 10.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "ZjgCVOUZ6mE", "JFMwotDdZNz", new DateTime(2023, 8, 1, 21, 56, 45, 105, DateTimeKind.Local).AddTicks(2313), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Lenovo IdeaPad 5 Pro 16ACH6", 29999, "AMD Ryzen 7", 2.0, "Екран 16\" IPS (2560x1600) WQXGA, матовий / AMD Ryzen 7 5800H (3.2 - 4.4 ГГц) / RAM 16 ГБ / SSD 512 ГБ / NVIDIA GeForce RTX 3050, 4 ГБ / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 2.2 кг / сірий" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "Name", "Priority", "ProductId" },
                values: new object[,]
                {
                    { "_FNzxqCNp7K", null, "4_2.webp", 2, "9aqWnqAwPmq" },
                    { "_WUylZTdFYi", null, "1_1.webp", 1, "HAJ--QhNcHt" },
                    { "_yvPsaiG6Po", null, "3_1.webp", 1, "wZttGY5B8sb" },
                    { "-14_T4Dy30Z", null, "1_3.webp", 3, "so4b0EsnwD3" },
                    { "-8SlXTY3yDM", null, "6_3.webp", 3, "O5JrjbFj983" },
                    { "-9eUdGrVOMB", null, "1_1.webp", 1, "so4b0EsnwD3" },
                    { "3BrgOOrgre-", null, "3_1.webp", 1, "9maYYCTeCU-" },
                    { "3C0DRy_cX0P", null, "3_2.webp", 2, "DyhZ-Qm3RUe" },
                    { "3gLET18XpTs", null, "2_2.webp", 2, "vLss89S6Atc" },
                    { "4SFBtLq5viS", null, "5_3.webp", 3, "uTy0b5fjlBN" },
                    { "4Z9sgyMNs6u", null, "1_2.webp", 2, "PZVWjYvMdHP" },
                    { "62uxfBRdyFP", null, "3_3.webp", 3, "9maYYCTeCU-" },
                    { "6mQ-3JubbuZ", null, "1_3.webp", 3, "PZVWjYvMdHP" },
                    { "7519HsWdxKl", null, "4_3.webp", 3, "938kYMQ6YD_" },
                    { "A8xGCuNRbjn", null, "2_2.webp", 2, "Jzfx_EpnZOP" },
                    { "aGfirM1Wzc7", null, "1_1.webp", 1, "AB9dPMRxx2l" },
                    { "ARWg3UE57pu", null, "3_2.webp", 2, "QXFjRrimIZD" },
                    { "aweiCkmnH_1", null, "4_1.webp", 1, "6xNhyanBp7i" },
                    { "BuLPNjYEg9j", null, "3_1.webp", 1, "uzAmcyIr-pr" },
                    { "cDYFRP3-C1l", null, "1_1.webp", 1, "PZVWjYvMdHP" },
                    { "EIdYfjqlz2N", null, "3_1.webp", 1, "55LcIJu2KpP" },
                    { "EOMteIBMaig", null, "6_2.webp", 2, "SkHRhpGZYxa" },
                    { "eqvM75n6Dn-", null, "3_2.webp", 2, "9maYYCTeCU-" },
                    { "FupLBhtNjzA", null, "5_3.webp", 3, "jl5r0PmjfFJ" },
                    { "Gf70RTii9ix", null, "4_1.webp", 1, "9aqWnqAwPmq" },
                    { "ghLVd_uQmpL", null, "3_1.webp", 1, "DyhZ-Qm3RUe" },
                    { "GpDqScEkzQG", null, "1_3.webp", 3, "AB9dPMRxx2l" },
                    { "hm1QRAmIuHQ", null, "1_2.webp", 2, "so4b0EsnwD3" },
                    { "HSXmaEzvGLX", null, "4_3.webp", 3, "9aqWnqAwPmq" },
                    { "I8FRiZBSBl8", null, "3_3.webp", 3, "wZttGY5B8sb" },
                    { "iCqV7xyGPMZ", null, "5_3.webp", 3, "DaQ5_0nnthZ" },
                    { "IJ72q1xPu8t", null, "6_2.webp", 2, "GnLcBELByjy" },
                    { "IMW1bNTS8lo", null, "1_2.webp", 2, "AB9dPMRxx2l" },
                    { "jb8AAmuzDFb", null, "5_2.webp", 2, "DaQ5_0nnthZ" },
                    { "jjiq3UjCgFH", null, "2_3.webp", 3, "ZjgCVOUZ6mE" },
                    { "kiZCzRXJp7p", null, "2_3.webp", 3, "vLss89S6Atc" },
                    { "kt5S5wK4jGC", null, "2_1.webp", 1, "Jzfx_EpnZOP" },
                    { "l34f2H2hXAW", null, "5_1.webp", 1, "uTy0b5fjlBN" },
                    { "lExeXyvAXuZ", null, "6_3.webp", 3, "GnLcBELByjy" },
                    { "lNrUNwiMWmI", null, "6_1.webp", 1, "O5JrjbFj983" },
                    { "m5GZbOf9fiJ", null, "2_3.webp", 3, "Jzfx_EpnZOP" },
                    { "MhcK3eF7OHo", null, "6_2.webp", 2, "O5JrjbFj983" },
                    { "NG1zpHYZ0Xn", null, "3_3.webp", 3, "DyhZ-Qm3RUe" },
                    { "OsWXYlyyQ94", null, "3_2.webp", 2, "55LcIJu2KpP" },
                    { "oY0q9N8_1_O", null, "6_3.webp", 3, "SkHRhpGZYxa" },
                    { "P5tJuHgrYrp", null, "5_2.webp", 2, "jl5r0PmjfFJ" },
                    { "qccgozSGWad", null, "2_1.webp", 1, "vLss89S6Atc" },
                    { "QeDnXHapWOd", null, "6_1.webp", 1, "SkHRhpGZYxa" },
                    { "QPCOQet9_9D", null, "6_1.webp", 1, "GnLcBELByjy" },
                    { "qY4jAsqQhYe", null, "4_1.webp", 1, "938kYMQ6YD_" },
                    { "RAJ3lRA7J_i", null, "1_2.webp", 2, "HAJ--QhNcHt" },
                    { "RBEKn9vERqJ", null, "3_3.webp", 3, "QXFjRrimIZD" },
                    { "rSduYBVJIwt", null, "5_2.webp", 2, "uTy0b5fjlBN" },
                    { "SFlcLEvyA3_", null, "2_1.webp", 1, "ZjgCVOUZ6mE" },
                    { "SoEJo8ocFqH", null, "3_2.webp", 2, "uzAmcyIr-pr" },
                    { "soYNUXXfkDS", null, "2_2.webp", 2, "ZjgCVOUZ6mE" },
                    { "TSS-WbPbFg3", null, "4_2.webp", 2, "938kYMQ6YD_" },
                    { "U1NCHm6YY9D", null, "4_3.webp", 3, "6xNhyanBp7i" },
                    { "UTHaG2pwFgQ", null, "3_2.webp", 2, "wZttGY5B8sb" },
                    { "VoPUZEv-U8f", null, "5_1.webp", 1, "jl5r0PmjfFJ" },
                    { "X-aefPJKkRG", null, "3_1.webp", 1, "QXFjRrimIZD" },
                    { "XmwYFGndg1P", null, "4_2.webp", 2, "6xNhyanBp7i" },
                    { "ZGvSwiLl39q", null, "3_3.webp", 3, "uzAmcyIr-pr" },
                    { "zuKoiIaCUWj", null, "3_3.webp", 3, "55LcIJu2KpP" },
                    { "Zx2XCKAOaOa", null, "1_3.webp", 3, "HAJ--QhNcHt" },
                    { "zZD1l6pSTtK", null, "5_1.webp", 1, "DaQ5_0nnthZ" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "MaxValue", "MinValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "2OkofcctUQD", "H4FLS7bDoyL", 0.0, 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "7Vh1_TRtgK2", "H4FLS7bDoyL", 0.0, 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "Ag8RAQkmwTa", "79Xa4Z4OW9m", 0.0, 0.0, "Intel Core i5", "Intel Core i5" },
                    { "F_MWfKPGlX1", "a4ftuWBbKi7", 24.0, 16.0, "16 - 24 ГБ", null },
                    { "FPhqc1Ct8nQ", "79Xa4Z4OW9m", 0.0, 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "hdKwd0W0BUy", "79Xa4Z4OW9m", 0.0, 0.0, "Intel Core i7", "Intel Core i7" },
                    { "HWXG1Ogpi0i", "a4ftuWBbKi7", 3.0, 0.20000000000000001, "3 ГБ і менше", null },
                    { "IPy68WU4Bbo", "H4FLS7bDoyL", 0.0, 0.0, "GeForce RTX 3050", "RTX 3050" },
                    { "lw6O2M1Dn59", "a4ftuWBbKi7", 8.0, 6.0, "6 - 8 ГБ", null },
                    { "mi6UU02hZ60", "mRX96bFOXhr", 4999.0, 4000.0, "4000 - 4999 мА*год ", null },
                    { "MLHgKjCmu1S", "a4ftuWBbKi7", 12.0, 10.0, "10 - 12 ГБ", null },
                    { "mYGRrUARH6g", "tlh3NxncHJc", 6.0, 5.5, "5.5\" - 6\"", null },
                    { "O4LnA_cxjF3", "tlh3NxncHJc", 5.0, 4.5999999999999996, "4.6\" - 5\"", null },
                    { "pbRo71Cz7EN", "tlh3NxncHJc", 5.5, 5.0099999999999998, "5.01\" - 5.5\"", null },
                    { "R-oqCtNIqPu", "a4ftuWBbKi7", 4.0, 4.0, "4 ГБ", null },
                    { "ur6KI9q2SC-", "mRX96bFOXhr", 3999.0, 3000.0, "3000 - 3999 мА*год ", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_tbl_Products_ProductId",
                table: "Comments",
                column: "ProductId",
                principalTable: "tbl_Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_tbl_Users_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "tbl_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
