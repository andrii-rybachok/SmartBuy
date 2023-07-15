using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class addlaptoptelephoneseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "DisplayDiagonal",
                table: "tbl_Products",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StringValue",
                table: "tbl_FilterValues",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<float>(
                name: "DisplayDiagonal",
                table: "tbl_Products",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StringValue",
                table: "tbl_FilterValues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
