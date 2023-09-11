using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class addedimages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_ProductImages");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "eJuRfCp8oBA");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "1VSu9z32oEI");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "4k-_zPH5aE8");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "4Nw0EKPqUJO");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "an4AqVcHr3b");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "bU0iF4mIsXc");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "BZGz5VoZdoK");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "Jdk8ekT-t0o");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "KSjZe2WI28j");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "Rw-ksJ9nMlP");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "sSuHpqjdYIn");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "teh8L9gMgc6");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "usT-thnEV7i");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "xha8XErHHKg");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "YjDt_JwhxrS");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "YZp2lgzFyDv");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "zvEJXe7ehLB");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "1KaUIFYyWA8");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "3Vs8IA3MFra");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "3ylY-zQX9qt");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "5fY2puMQG6K");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "6Fctd_GleNm");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "aanCO2YRI_C");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "AHesZzh14Hi");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "e7vNrOhzrU_");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "f8XIPoSvl1s");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "IJEDul3FKIR");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "iRRHetY4kX0");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "JW2M6p6gwmm");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "kHq-jPvDCTF");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "LSdVBgs_Xrq");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "n7IUGowG5Bk");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "NPEt62R6t2L");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Q7QfIvyXLsu");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "rcsLpR-3DDj");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "SxOdbJ4VGCY");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "TmUvC0A_aSh");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "TUuIt9yeV4e");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "UKJzBV2CxJW");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "vL5B8aPLFni");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "WI5XXk80xWO");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "WIohpaR6Ba0");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "WRUsNOMGhgu");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "x1rl4dVjwO7");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "YYkzGd08dHJ");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "6mv0VMn1JQF");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "mAwLtseC9GC");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "NlDHPtVuh8K");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "uatfIaIsSMY");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "-g6ogjcKT3g");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "2X4wwRhBkn0");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "Fzf58pF80CB");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "rtobiL_Hz9q");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "uA-nN6DXmQw");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "KriVA367QQg");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "x0zQVCbSXUY");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "tbl_Categories");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        name: "FK_Images_tbl_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tbl_Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "472vQ0ew_Fy", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(888), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Побутова техніка" },
                    { "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(794), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Комп'ютери та ноутбуки" },
                    { "JB3MqTmqkHr", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(892), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Дача, сад, город" },
                    { "NuU8MBo32_v", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(901), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Офіс, школа, книги" },
                    { "q9fuuV0bjOx", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(895), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Спорт і захоплення" },
                    { "rM7oALRkviQ", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(904), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", false, "test" },
                    { "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(847), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", false, "Смартфони" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "Name", "ProductId" },
                values: new object[,]
                {
                    { "2LtlGmlNT3y", "cIAcW0JP8Fe", "3_1.webp", null },
                    { "qb7xdzKEYZf", "wSixlKgmsHo", "5_1.webp", null }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Name", "PublicName" },
                values: new object[,]
                {
                    { "2iAzHsfxpMp", "wSixlKgmsHo", "DisplayDiagonal", "Діагональ екрана" },
                    { "8RfpGsNHPI5", "cIAcW0JP8Fe", "Processor", "Процесор" },
                    { "bGShc-vBpEF", "cIAcW0JP8Fe", "RAM", "Обсяг оперативної пам'яті" },
                    { "Em17l23mxHE", "cIAcW0JP8Fe", "GraphicCard", "Дискретна відеокарта" },
                    { "LgQojtj9Qxc", "wSixlKgmsHo", "BatteryCapacity", "Ємність акумулятора" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "_F-l5r_BjjS", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1275), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 11.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "2R-ukmceUBo", 5000, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.8099999999999996, false, "Мобільний телефон Xiaomi Mi 12", 39999, "Екран (6.81\", OLED, 3200x1440) / Qualcomm Snapdragon 8 Gen 1 / основна квадро-камера: 50 Мп + 12 Мп + 8 Мп + 2 Мп, фронтальна камера: 32 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Dual SIM / Android 12" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[,]
                {
                    { "aeYQ1GK7ERZ", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 12.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "chB5TxvQXpv", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1292), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 1.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "e5nvhk4ecZt", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1290), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 3.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 8 ГБ / SSD 128 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "EoteY1-cP36", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1278), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 10.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "eqT_A3Z7qXO", 4800, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "eZwkfGX6rfs", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1281), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "G6EV8bzX3LV", "q9fuuV0bjOx", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(1027), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", 0, "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "Gg2V7BV3gcA", 4900, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1354), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "gv_IoJytHc7", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1286), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "Intel Iris Xe Graphics", false, "Ноутбук HP Pavilion 15-cs3006ur Natural Silver", 23999, "Intel Core i5", 16.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / Intel Core i5-1135G7 (2.4 - 4.2 ГГц) / RAM 8 ГБ / SSD 256 ГБ / Intel Iris Xe Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 1.75 кг / сріблястий" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "hcnxfTOQIOb", 4600, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1358), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "HwDnpVwuzgz", "NuU8MBo32_v", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(1031), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", 0, "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "ihWFxmX-6ly", 4100, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1346), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "iW652IUQNFH", 3600, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1347), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "JomKFCLeIbl", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(1007), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", 0, "ProductEntity", false, "ПК Х123434", 436765, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "L3tPCT9TwCS", 3100, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1343), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "mNnwbQIZ_4H", 5000, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1362), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.5, false, "Мобільний телефон Sony Xperia 1 IV", 74999, "Екран (6.5\", OLED, 3840x1644) / Qualcomm Snapdragon 888 / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 10 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12" },
                    { "NTBk5t92kWW", 4500, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1360), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2000000000000002, false, "Мобільний телефон Google Pixel 7", 32999, "Екран (6.2\", OLED, 2400x1080) / Qualcomm Snapdragon 778G / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / eSIM / Android 12" },
                    { "pUtVJhB7QgI", 4000, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1366), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.0999999999999996, false, "Мобільний телефон Samsung Galaxy S22", 45999, "Екран (6.1\", Dynamic AMOLED 2X, 1080x2400) / Samsung Exynos 2200 / основна квадро-камера: 50 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 10 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[,]
                {
                    { "R29EwSBq4CO", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1283), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "Rjr8GXx-_X4", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1269), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 7.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "SLlFSLlFcmt", 3900, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1349), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "W_QHkpGu_wQ", 4200, "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1356), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "WayZJaEneo1", "JB3MqTmqkHr", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(1023), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", 0, "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" },
                    { "x98c5Ed31bt", "wSixlKgmsHo", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(1014), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", 0, "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "xv0youuXIU6", "cIAcW0JP8Fe", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Local).AddTicks(1288), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Lenovo IdeaPad 5 Pro 16ACH6", 29999, "AMD Ryzen 7", 2.0, "Екран 16\" IPS (2560x1600) WQXGA, матовий / AMD Ryzen 7 5800H (3.2 - 4.4 ГГц) / RAM 16 ГБ / SSD 512 ГБ / NVIDIA GeForce RTX 3050, 4 ГБ / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 2.2 кг / сірий" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "yznEr1SrUkR", "472vQ0ew_Fy", new DateTime(2023, 8, 1, 16, 49, 12, 965, DateTimeKind.Utc).AddTicks(1019), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", 0, "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "Name", "ProductId" },
                values: new object[,]
                {
                    { "_EUetdr87C-", null, "1_2.webp", "R29EwSBq4CO" },
                    { "_JY9Mu8w1IC", null, "0_3.webp", "e5nvhk4ecZt" },
                    { "-t5xyXBStL1", null, "5_2.webp", "2R-ukmceUBo" },
                    { "0wJF29GmXhd", null, "5_3.webp", "iW652IUQNFH" },
                    { "3PFZvrujrtk", null, "6_2.webp", "SLlFSLlFcmt" },
                    { "3TVlVG3aBKe", null, "5_1.webp", "W_QHkpGu_wQ" },
                    { "6cLXG3yXwqF", null, "5_3.webp", "W_QHkpGu_wQ" },
                    { "6CpBQ1qPVf7", null, "0_3.webp", "eZwkfGX6rfs" },
                    { "6Xl3rieuxDu", null, "2_1.webp", "EoteY1-cP36" },
                    { "7WSruBI7BkI", null, "3_1.webp", "xv0youuXIU6" },
                    { "9DxpOIqJBsc", null, "5_1.webp", "2R-ukmceUBo" },
                    { "9z0WWvLL1a0", null, "1_2.webp", "chB5TxvQXpv" },
                    { "aH6vzStU4bw", null, "2_3.webp", "EoteY1-cP36" },
                    { "bn9BkviCAjL", null, "3_1.webp", "eqT_A3Z7qXO" },
                    { "BYti-1wzjXj", null, "2_2.webp", "gv_IoJytHc7" },
                    { "DdHfWy3rK5D", null, "6_1.webp", "SLlFSLlFcmt" },
                    { "Dm0IgxIWULg", null, "6_1.webp", "pUtVJhB7QgI" },
                    { "EgM7ehtyXcT", null, "4_1.webp", "mNnwbQIZ_4H" },
                    { "ET4N0p4pmzc", null, "3_2.webp", "xv0youuXIU6" },
                    { "FpeDnoMj6sz", null, "6_3.webp", "pUtVJhB7QgI" },
                    { "g03QwMkou8Q", null, "6_1.webp", "hcnxfTOQIOb" },
                    { "hp9FinqT18P", null, "0_1.webp", "e5nvhk4ecZt" },
                    { "HV5BOvqXmDy", null, "3_3.webp", "L3tPCT9TwCS" },
                    { "iFazZGuXg3j", null, "0_2.webp", "Rjr8GXx-_X4" },
                    { "iLGaLFMiW0x", null, "3_1.webp", "NTBk5t92kWW" },
                    { "Jbf3h9hXmKr", null, "3_1.webp", "aeYQ1GK7ERZ" },
                    { "JCDrjo9Nyk7", null, "4_3.webp", "ihWFxmX-6ly" },
                    { "JoUmgC_TwuS", null, "6_2.webp", "pUtVJhB7QgI" },
                    { "jretvFcCW8x", null, "0_1.webp", "Rjr8GXx-_X4" },
                    { "JWqcYd98rGg", null, "3_1.webp", "L3tPCT9TwCS" },
                    { "jYqkobnCxyH", null, "5_2.webp", "iW652IUQNFH" },
                    { "k12term59WZ", null, "1_3.webp", "chB5TxvQXpv" },
                    { "LCZTpAU4EGe", null, "1_3.webp", "R29EwSBq4CO" },
                    { "lm49gEOW-Y8", null, "3_3.webp", "xv0youuXIU6" },
                    { "McN4GvcECyu", null, "6_3.webp", "hcnxfTOQIOb" },
                    { "mPHWFsUCeNH", null, "1_1.webp", "_F-l5r_BjjS" },
                    { "nTLCr9KmZjp", null, "4_1.webp", "ihWFxmX-6ly" },
                    { "NVayL-20mLj", null, "4_3.webp", "mNnwbQIZ_4H" },
                    { "O93bf5JrsfV", null, "3_2.webp", "L3tPCT9TwCS" },
                    { "on-UxRGknq0", null, "5_1.webp", "iW652IUQNFH" },
                    { "On9spr6Rfen", null, "0_2.webp", "e5nvhk4ecZt" },
                    { "oVmpdcKS71f", null, "1_1.webp", "chB5TxvQXpv" },
                    { "oWCWeDmMknu", null, "5_2.webp", "W_QHkpGu_wQ" },
                    { "pI_uYRzwYQ5", null, "3_3.webp", "eqT_A3Z7qXO" },
                    { "pN6E8bRkF5S", null, "5_3.webp", "2R-ukmceUBo" },
                    { "Qi7_P7PGTKB", null, "4_3.webp", "Gg2V7BV3gcA" },
                    { "QK7TnlGJ0D6", null, "2_1.webp", "gv_IoJytHc7" },
                    { "qsmvQVaGxQA", null, "3_2.webp", "aeYQ1GK7ERZ" },
                    { "RoK4NgqI8a6", null, "6_3.webp", "SLlFSLlFcmt" },
                    { "SASL65NJF_u", null, "2_3.webp", "gv_IoJytHc7" },
                    { "tHzXgGI4nYN", null, "4_2.webp", "ihWFxmX-6ly" },
                    { "UFq355o6row", null, "0_2.webp", "eZwkfGX6rfs" },
                    { "utVU8pHPspG", null, "4_2.webp", "Gg2V7BV3gcA" },
                    { "w-L8FTmJWFH", null, "3_3.webp", "NTBk5t92kWW" },
                    { "WbDePZ-QpS5", null, "1_2.webp", "_F-l5r_BjjS" },
                    { "wHu1eKET278", null, "1_3.webp", "_F-l5r_BjjS" },
                    { "Wok1PSiWhqT", null, "3_3.webp", "aeYQ1GK7ERZ" },
                    { "x1xmRXTTbem", null, "0_1.webp", "eZwkfGX6rfs" },
                    { "XEPKbA5LHcD", null, "6_2.webp", "hcnxfTOQIOb" },
                    { "XnbQTa_AYdA", null, "2_2.webp", "EoteY1-cP36" },
                    { "XUoLgelBq5N", null, "1_1.webp", "R29EwSBq4CO" },
                    { "yMjGNE_AdUR", null, "4_2.webp", "mNnwbQIZ_4H" },
                    { "Z_EqfKNrIUJ", null, "3_2.webp", "NTBk5t92kWW" },
                    { "zDj9iSzFmq2", null, "0_3.webp", "Rjr8GXx-_X4" },
                    { "ZrVaDidEtdc", null, "4_1.webp", "Gg2V7BV3gcA" },
                    { "zZiIFLmphLT", null, "3_2.webp", "eqT_A3Z7qXO" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "MaxValue", "MinValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "_Ofo9TF1q0Z", "bGShc-vBpEF", 12.0, 10.0, "10 - 12 ГБ", null },
                    { "0uYOunvyqLP", "8RfpGsNHPI5", 0.0, 0.0, "Intel Core i5", "Intel Core i5" },
                    { "9MfWX_tmEsb", "LgQojtj9Qxc", 3999.0, 3000.0, "3000 - 3999 мА*год ", null },
                    { "bH8f_SIH6pw", "2iAzHsfxpMp", 5.5, 5.0099999999999998, "5.01\" - 5.5\"", null },
                    { "C87zmLkNM2J", "Em17l23mxHE", 0.0, 0.0, "GeForce RTX 3050", "RTX 3050" },
                    { "cZwLzzw4Pq7", "2iAzHsfxpMp", 6.0, 5.5, "5.5\" - 6\"", null },
                    { "inSxRGMGdrG", "8RfpGsNHPI5", 0.0, 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "Kixv-fwwfk6", "Em17l23mxHE", 0.0, 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "mDae0aBgJU2", "bGShc-vBpEF", 3.0, 0.20000000000000001, "3 ГБ і менше", null },
                    { "mrNdi550R_k", "Em17l23mxHE", 0.0, 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "qCmzwe9ybtp", "8RfpGsNHPI5", 0.0, 0.0, "Intel Core i7", "Intel Core i7" },
                    { "R2EJ7NdB4G6", "bGShc-vBpEF", 24.0, 16.0, "16 - 24 ГБ", null },
                    { "UiBCXX8z3xa", "bGShc-vBpEF", 4.0, 4.0, "4 ГБ", null },
                    { "WDHgOhHsB0R", "LgQojtj9Qxc", 4999.0, 4000.0, "4000 - 4999 мА*год ", null },
                    { "xBMpgx0SOOR", "bGShc-vBpEF", 8.0, 6.0, "6 - 8 ГБ", null },
                    { "z73qR7kJeuI", "2iAzHsfxpMp", 5.0, 4.5999999999999996, "4.6\" - 5\"", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_CategoryId",
                table: "Images",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "rM7oALRkviQ");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "_Ofo9TF1q0Z");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "0uYOunvyqLP");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "9MfWX_tmEsb");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "bH8f_SIH6pw");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "C87zmLkNM2J");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "cZwLzzw4Pq7");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "inSxRGMGdrG");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "Kixv-fwwfk6");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "mDae0aBgJU2");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "mrNdi550R_k");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "qCmzwe9ybtp");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "R2EJ7NdB4G6");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "UiBCXX8z3xa");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "WDHgOhHsB0R");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "xBMpgx0SOOR");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "z73qR7kJeuI");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "_F-l5r_BjjS");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "2R-ukmceUBo");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "aeYQ1GK7ERZ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "chB5TxvQXpv");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "e5nvhk4ecZt");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "EoteY1-cP36");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "eqT_A3Z7qXO");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "eZwkfGX6rfs");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "G6EV8bzX3LV");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Gg2V7BV3gcA");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "gv_IoJytHc7");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "hcnxfTOQIOb");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "HwDnpVwuzgz");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "ihWFxmX-6ly");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "iW652IUQNFH");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "JomKFCLeIbl");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "L3tPCT9TwCS");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "mNnwbQIZ_4H");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "NTBk5t92kWW");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "pUtVJhB7QgI");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "R29EwSBq4CO");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Rjr8GXx-_X4");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "SLlFSLlFcmt");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "W_QHkpGu_wQ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "WayZJaEneo1");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "x98c5Ed31bt");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "xv0youuXIU6");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "yznEr1SrUkR");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "472vQ0ew_Fy");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "JB3MqTmqkHr");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "NuU8MBo32_v");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "q9fuuV0bjOx");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "2iAzHsfxpMp");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "8RfpGsNHPI5");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "bGShc-vBpEF");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "Em17l23mxHE");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "LgQojtj9Qxc");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "cIAcW0JP8Fe");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "wSixlKgmsHo");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "tbl_Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "tbl_ProductImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_ProductImages_tbl_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tbl_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "6mv0VMn1JQF", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7570), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "eJuRfCp8oBA", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7578), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" },
                    { "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7560), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" },
                    { "mAwLtseC9GC", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7564), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" },
                    { "NlDHPtVuh8K", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7567), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" },
                    { "uatfIaIsSMY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7575), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7507), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Name", "PublicName" },
                values: new object[,]
                {
                    { "-g6ogjcKT3g", "x0zQVCbSXUY", "RAM", "Обсяг оперативної пам'яті" },
                    { "2X4wwRhBkn0", "x0zQVCbSXUY", "GraphicCard", "Дискретна відеокарта" },
                    { "Fzf58pF80CB", "x0zQVCbSXUY", "Processor", "Процесор" },
                    { "rtobiL_Hz9q", "KriVA367QQg", "BatteryCapacity", "Ємність акумулятора" },
                    { "uA-nN6DXmQw", "KriVA367QQg", "DisplayDiagonal", "Діагональ екрана" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "1KaUIFYyWA8", 3600, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8045), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[,]
                {
                    { "3Vs8IA3MFra", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "3ylY-zQX9qt", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7998), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 1.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "5fY2puMQG6K", "NlDHPtVuh8K", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7679), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", 0, "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "6Fctd_GleNm", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7986), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", 12.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "aanCO2YRI_C", 5000, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8060), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.5, false, "Мобільний телефон Sony Xperia 1 IV", 74999, "Екран (6.5\", OLED, 3840x1644) / Qualcomm Snapdragon 888 / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 10 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "AHesZzh14Hi", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7989), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 4.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "e7vNrOhzrU_", 4600, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8055), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "f8XIPoSvl1s", "mAwLtseC9GC", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7675), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", 0, "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "IJEDul3FKIR", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7996), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 3.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 8 ГБ / SSD 128 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "iRRHetY4kX0", "6mv0VMn1JQF", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7683), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", 0, "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "JW2M6p6gwmm", 4900, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8051), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "kHq-jPvDCTF", "uatfIaIsSMY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7741), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", 0, "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "LSdVBgs_Xrq", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7992), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "Intel Iris Xe Graphics", false, "Ноутбук HP Pavilion 15-cs3006ur Natural Silver", 23999, "Intel Core i5", 16.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / Intel Core i5-1135G7 (2.4 - 4.2 ГГц) / RAM 8 ГБ / SSD 256 ГБ / Intel Iris Xe Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 1.75 кг / сріблястий" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "n7IUGowG5Bk", 4200, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8053), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "NPEt62R6t2L", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7983), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 10.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "Q7QfIvyXLsu", 4800, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8049), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "rcsLpR-3DDj", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7978), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", 7.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "SxOdbJ4VGCY", "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7671), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", 0, "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "TmUvC0A_aSh", 3900, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8047), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "TUuIt9yeV4e", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7981), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i5", 11.0, "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "UKJzBV2CxJW", 4100, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8043), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "vL5B8aPLFni", 4000, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8064), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.0999999999999996, false, "Мобільний телефон Samsung Galaxy S22", 45999, "Екран (6.1\", Dynamic AMOLED 2X, 1080x2400) / Samsung Exynos 2200 / основна квадро-камера: 50 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 10 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12" },
                    { "WI5XXk80xWO", 5000, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8062), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.8099999999999996, false, "Мобільний телефон Xiaomi Mi 12", 39999, "Екран (6.81\", OLED, 3200x1440) / Qualcomm Snapdragon 8 Gen 1 / основна квадро-камера: 50 Мп + 12 Мп + 8 Мп + 2 Мп, фронтальна камера: 32 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Dual SIM / Android 12" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "RAM", "ShortDescription" },
                values: new object[] { "WIohpaR6Ba0", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(7994), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Laptop", "RTX 3050", false, "Ноутбук Lenovo IdeaPad 5 Pro 16ACH6", 29999, "AMD Ryzen 7", 2.0, "Екран 16\" IPS (2560x1600) WQXGA, матовий / AMD Ryzen 7 5800H (3.2 - 4.4 ГГц) / RAM 16 ГБ / SSD 512 ГБ / NVIDIA GeForce RTX 3050, 4 ГБ / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 2.2 кг / сірий" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "WRUsNOMGhgu", 3100, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8041), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "x1rl4dVjwO7", 4500, "KriVA367QQg", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Local).AddTicks(8057), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", 0, "Telephone", 6.2000000000000002, false, "Мобільний телефон Google Pixel 7", 32999, "Екран (6.2\", OLED, 2400x1080) / Qualcomm Snapdragon 778G / основна камера: 64 Мп + 16 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / eSIM / Android 12" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Dicount", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "YYkzGd08dHJ", "x0zQVCbSXUY", new DateTime(2023, 7, 30, 18, 50, 38, 311, DateTimeKind.Utc).AddTicks(7665), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", 0, "ProductEntity", false, "ПК Х123434", 436765, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "MaxValue", "MinValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "1VSu9z32oEI", "2X4wwRhBkn0", 0.0, 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "4k-_zPH5aE8", "Fzf58pF80CB", 0.0, 0.0, "Intel Core i5", "Intel Core i5" },
                    { "4Nw0EKPqUJO", "uA-nN6DXmQw", 5.0, 4.5999999999999996, "4.6\" - 5\"", null },
                    { "an4AqVcHr3b", "-g6ogjcKT3g", 12.0, 10.0, "10 - 12 ГБ", null },
                    { "bU0iF4mIsXc", "rtobiL_Hz9q", 4999.0, 4000.0, "4000 - 4999 мА*год ", null },
                    { "BZGz5VoZdoK", "2X4wwRhBkn0", 0.0, 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "Jdk8ekT-t0o", "uA-nN6DXmQw", 6.0, 5.5, "5.5\" - 6\"", null },
                    { "KSjZe2WI28j", "Fzf58pF80CB", 0.0, 0.0, "Intel Core i7", "Intel Core i7" },
                    { "Rw-ksJ9nMlP", "-g6ogjcKT3g", 3.0, 0.20000000000000001, "3 ГБ і менше", null },
                    { "sSuHpqjdYIn", "-g6ogjcKT3g", 4.0, 4.0, "4 ГБ", null },
                    { "teh8L9gMgc6", "2X4wwRhBkn0", 0.0, 0.0, "GeForce RTX 3050", "RTX 3050" },
                    { "usT-thnEV7i", "Fzf58pF80CB", 0.0, 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "xha8XErHHKg", "-g6ogjcKT3g", 8.0, 6.0, "6 - 8 ГБ", null },
                    { "YjDt_JwhxrS", "-g6ogjcKT3g", 24.0, 16.0, "16 - 24 ГБ", null },
                    { "YZp2lgzFyDv", "uA-nN6DXmQw", 5.5, 5.0099999999999998, "5.01\" - 5.5\"", null },
                    { "zvEJXe7ehLB", "rtobiL_Hz9q", 3999.0, 3000.0, "3000 - 3999 мА*год ", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ProductImages_ProductId",
                table: "tbl_ProductImages",
                column: "ProductId");
        }
    }
}
