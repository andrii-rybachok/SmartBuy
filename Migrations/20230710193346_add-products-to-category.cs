using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class addproductstocategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "8MySwsorqBE");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "AliDyNsXata");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "MTG6OcVkaes");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "r-WduzRwSW1");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "ri4CUSIbxxT");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "TuJWTZVZIPw");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "uARtvFbbfxf");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "uXTzU1Ck42D");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "Zvmck6wiC26");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "ZyNEBGwfHB2");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "_pD7w_BmyKi");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "06_PMzqVOjd");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "1fRZ4xxFuCa");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "3CQaf-8FSKK");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "4IQe8UKGuIz");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "b3KniRveqOP");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "BHQ8ushOHMi");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "ffJ3miRa0WG");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "fHlRQzQkHBD");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "FmUxyqlfrF1");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "FNIIbeIwm7v");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "lL0721BFhVb");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "NGYDoPAqKF-");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "RtAOew0JLPV");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "u0GumC_FCM0");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "uV-RwQOf-rx");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "VZhtRTcyWdM");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "wATT_-ZeS5-");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "X_fUke4NGT9");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "zzVxUCRnjb0");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "cDBHvbKRYsP");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "CgsQ-sp__TK");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "j7d12hI0shh");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "Wxp-QblivER");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "_izGeGVJIqG");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "1Tt1eB70hN1");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "eB7tRNx6lGh");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "jCLHqkenD2d");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "85fXk3KWpYn");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "B-1JLYPBCT5");

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "-oQoVsYfKqm", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2128), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { "0xzCc3IYXXP", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2195), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { "h0ajsVVZOaT", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2190), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "LLkvLGVgERO", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2187), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" },
                    { "lpSk4QwMexb", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2184), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" },
                    { "LVmH3muYtKg", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2198), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" },
                    { "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2180), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Name", "PublicName" },
                values: new object[,]
                {
                    { "-uvwoPeDwIC", "-oQoVsYfKqm", "Processor", "Процесор" },
                    { "5VjchSHEwOC", "-oQoVsYfKqm", "GraphicCard", "Дискретна відеокарта" },
                    { "FZ2xCXncAMt", "p4mKkhZcWh3", "BatteryCapacity", "Ємність акумулятора" },
                    { "JS5GXNv1yYf", "p4mKkhZcWh3", "DisplayDiagonal", "Діагональ екрана" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[,]
                {
                    { "_14WVrdYO8P", "-oQoVsYfKqm", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2523), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "0_t7P6jOTfM", "-oQoVsYfKqm", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2518), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "5_WUBMgWKlc", "0xzCc3IYXXP", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2291), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "5AA9I-HoHZT", 3600, "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2606), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "6jhpEI2jg_x", 4200, "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2615), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[,]
                {
                    { "ATwlwxgIQJ7", "-oQoVsYfKqm", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2521), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "CsOf781VUHz", "-oQoVsYfKqm", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2528), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "EFKk5mzGNf-", 4100, "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2603), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "ghZICXDeD79", 4900, "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2612), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "Gpu3h6zbCTs", "-oQoVsYfKqm", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2265), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "ProductEntity", false, "ПК Х123434", 436765, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "iN6E_Doub1i", 3100, "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2566), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "jZeymDHu6_P", 4600, "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2617), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "K553x-yiaWM", 4800, "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2611), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "kafEB-2fhd5", "LLkvLGVgERO", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2283), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "kkLzGfENHGe", 3900, "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2608), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "NrZKCTSxF4O", "p4mKkhZcWh3", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2272), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" },
                    { "Od4fXlEcSbK", "lpSk4QwMexb", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2276), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" },
                    { "PHPUQ1JlHqG", "h0ajsVVZOaT", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Utc).AddTicks(2287), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[,]
                {
                    { "R_6Nr6KkOxA", "-oQoVsYfKqm", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "RUGG-VF5KJn", "-oQoVsYfKqm", new DateTime(2023, 7, 10, 21, 33, 46, 446, DateTimeKind.Local).AddTicks(2526), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "NumericValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "_p4EGmLez6b", "5VjchSHEwOC", 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "bECak3qP45c", "JS5GXNv1yYf", 5.5, "5.01\" - 5.5\"", null },
                    { "FKD_wyb7Ett", "-uvwoPeDwIC", 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "g5o7znVnlOJ", "FZ2xCXncAMt", 5000.0, "4000 - 4999 мА*год ", null },
                    { "HiuDX0efEYL", "-uvwoPeDwIC", 0.0, "Intel Core i7", "Intel Core i7" },
                    { "ICC2bBHdlTU", "5VjchSHEwOC", 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "MigMHkHnzad", "JS5GXNv1yYf", 5.0, "4.6\" - 5\"", null },
                    { "PxgKGSU5tMk", "FZ2xCXncAMt", 4000.0, "3000 - 3999 мА*год ", null },
                    { "UYNfnE_kI4e", "JS5GXNv1yYf", 6.0, "5.01\" - 5.5\"", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "LVmH3muYtKg");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "_p4EGmLez6b");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "bECak3qP45c");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "FKD_wyb7Ett");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "g5o7znVnlOJ");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "HiuDX0efEYL");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "ICC2bBHdlTU");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "MigMHkHnzad");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "PxgKGSU5tMk");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "UYNfnE_kI4e");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "_14WVrdYO8P");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "0_t7P6jOTfM");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "5_WUBMgWKlc");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "5AA9I-HoHZT");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "6jhpEI2jg_x");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "ATwlwxgIQJ7");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "CsOf781VUHz");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "EFKk5mzGNf-");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "ghZICXDeD79");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Gpu3h6zbCTs");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "iN6E_Doub1i");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "jZeymDHu6_P");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "K553x-yiaWM");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "kafEB-2fhd5");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "kkLzGfENHGe");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "NrZKCTSxF4O");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Od4fXlEcSbK");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "PHPUQ1JlHqG");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "R_6Nr6KkOxA");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "RUGG-VF5KJn");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "0xzCc3IYXXP");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "h0ajsVVZOaT");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "LLkvLGVgERO");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "lpSk4QwMexb");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "-uvwoPeDwIC");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "5VjchSHEwOC");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "FZ2xCXncAMt");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "JS5GXNv1yYf");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "-oQoVsYfKqm");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "p4mKkhZcWh3");

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "85fXk3KWpYn", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5418), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { "8MySwsorqBE", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5499), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" },
                    { "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5477), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" },
                    { "cDBHvbKRYsP", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5490), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "CgsQ-sp__TK", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5482), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" },
                    { "j7d12hI0shh", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5495), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { "Wxp-QblivER", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5486), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Name", "PublicName" },
                values: new object[,]
                {
                    { "_izGeGVJIqG", "85fXk3KWpYn", "GraphicCard", "Дискретна відеокарта" },
                    { "1Tt1eB70hN1", "B-1JLYPBCT5", "BatteryCapacity", "Ємність акумулятора" },
                    { "eB7tRNx6lGh", "85fXk3KWpYn", "Processor", "Процесор" },
                    { "jCLHqkenD2d", "B-1JLYPBCT5", "DisplayDiagonal", "Діагональ екрана" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "_pD7w_BmyKi", "Wxp-QblivER", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5585), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "06_PMzqVOjd", 3100, "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5849), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[] { "1fRZ4xxFuCa", "85fXk3KWpYn", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5806), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "3CQaf-8FSKK", "j7d12hI0shh", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5593), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[,]
                {
                    { "4IQe8UKGuIz", "85fXk3KWpYn", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5804), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "b3KniRveqOP", "85fXk3KWpYn", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5808), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "BHQ8ushOHMi", 4800, "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5857), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "ffJ3miRa0WG", 4900, "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5859), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "fHlRQzQkHBD", 3600, "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5853), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "FmUxyqlfrF1", "cDBHvbKRYsP", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5589), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "FNIIbeIwm7v", 4100, "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5851), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "lL0721BFhVb", "CgsQ-sp__TK", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5581), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[,]
                {
                    { "NGYDoPAqKF-", "85fXk3KWpYn", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "RtAOew0JLPV", "85fXk3KWpYn", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5802), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "u0GumC_FCM0", "85fXk3KWpYn", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5799), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "uV-RwQOf-rx", "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5576), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "VZhtRTcyWdM", 3900, "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5855), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "wATT_-ZeS5-", 4600, "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5864), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "X_fUke4NGT9", 4200, "B-1JLYPBCT5", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Local).AddTicks(5861), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "zzVxUCRnjb0", "85fXk3KWpYn", new DateTime(2023, 7, 9, 18, 38, 13, 883, DateTimeKind.Utc).AddTicks(5569), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "ProductEntity", false, "ПК Х123434", 436765, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "NumericValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "AliDyNsXata", "1Tt1eB70hN1", 5000.0, "4000 - 4999 мА*год ", null },
                    { "MTG6OcVkaes", "_izGeGVJIqG", 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "r-WduzRwSW1", "jCLHqkenD2d", 5.5, "5.01\" - 5.5\"", null },
                    { "ri4CUSIbxxT", "_izGeGVJIqG", 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "TuJWTZVZIPw", "jCLHqkenD2d", 6.0, "5.01\" - 5.5\"", null },
                    { "uARtvFbbfxf", "jCLHqkenD2d", 5.0, "4.6\" - 5\"", null },
                    { "uXTzU1Ck42D", "1Tt1eB70hN1", 4000.0, "3000 - 3999 мА*год ", null },
                    { "Zvmck6wiC26", "eB7tRNx6lGh", 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "ZyNEBGwfHB2", "eB7tRNx6lGh", 0.0, "Intel Core i7", "Intel Core i7" }
                });
        }
    }
}
