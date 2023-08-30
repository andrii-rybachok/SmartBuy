using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class Cart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "lw_-LKvVrcH");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "9HySyPlWeVw");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "9k2MT0KVK7Q");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "9Okc93c4auK");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "AZ0V4pa5t4r");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "E2PBnVYgp6h");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "gTZ7s5cp8Gq");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "NIUc1g4ON6Q");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "ruS6WnxOWBN");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "ylu6ybC1A1o");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "4MfV3csqIC0");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "4QuVsDU2Zln");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "AHmx3HmwPGQ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "cDwKeshlgeQ");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "dgTQ9quhm3z");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "fS97CMXw7YH");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "i-K_IO5HhWT");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "IONp1DJWuOU");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "JJ6MMAALVjR");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "jVctM12zvHK");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "l9aktPJblrx");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "LyQB8y0WPUe");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "MI13daCiXAL");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "OYGBt-bnxF4");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "PelHVxQmn8-");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "UXZ85FeIPLG");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "V04Tq-33pUS");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "WafSv6iL8Kl");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "wDnb3sWx34u");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "ZBLZP_-1_pi");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "k6gF0CsEuJ-");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "OGFvKGT57P5");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "rI1kYKYzDu7");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "VYMljuZGttj");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "KL6LqDoQ5SM");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "KZQrd4Xwrn_");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "PzjB2De92e_");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "tZ0ImTM8zm8");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "baADvNdQR7R");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "K_ZQE-j2tw4");

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "_IUhE4aXYE7", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3220), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { "4NEOOkvWhAp", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3319), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" },
                    { "66lQGoad65G", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3298), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" },
                    { "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3292), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" },
                    { "iw77oeYUjhH", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3307), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "IYKBQnEbZS1", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { "JHMotdJNPMD", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3302), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Name", "PublicName" },
                values: new object[,]
                {
                    { "1pc6gc4RExZ", "DkjxWIHmxKi", "BatteryCapacity", "Ємність акумулятора" },
                    { "At5FBTcuf6k", "_IUhE4aXYE7", "Processor", "Процесор" },
                    { "eeoduCDrXtC", "_IUhE4aXYE7", "GraphicCard", "Дискретна відеокарта" },
                    { "WpxGSoDbRWj", "DkjxWIHmxKi", "DisplayDiagonal", "Діагональ екрана" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "_ku_v5SDYRM", "_IUhE4aXYE7", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3422), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "ProductEntity", false, "ПК Х123434", 436765, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[] { "00v3Xx2Z-AL", "_IUhE4aXYE7", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3861), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "0Bewg4AB4no", 4600, "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3935), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[] { "4O-AAWxXqvk", "_IUhE4aXYE7", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3849), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "4TuQqz4BeUn", 4800, "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3928), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "7LiyrsIOP45", 4200, "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3933), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "8R0WpK54zF7", "66lQGoad65G", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3434), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[,]
                {
                    { "d3vYYWNDR1x", "_IUhE4aXYE7", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3852), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "dOboUZ_nHtE", "_IUhE4aXYE7", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3855), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "eYWoWVmXXTi", "JHMotdJNPMD", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3439), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" },
                    { "fllBA00AOvj", "IYKBQnEbZS1", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3454), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[] { "FsKua-kjvon", "_IUhE4aXYE7", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3843), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "hG8fjgKnvtb", "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3429), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" },
                    { "iTkm1EMrM_E", "iw77oeYUjhH", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Utc).AddTicks(3448), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "rcZkNfhApAE", 3100, "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3915), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "RrajEYIlXTw", 3600, "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3921), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "vMP6yQvHMTY", 4900, "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3930), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[] { "WrwxbL4GqF3", "_IUhE4aXYE7", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3858), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "XTi-sGs6uca", 4100, "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3919), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "yTkQXd_tAeM", 3900, "DkjxWIHmxKi", new DateTime(2023, 8, 30, 7, 7, 40, 339, DateTimeKind.Local).AddTicks(3925), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "MaxValue", "MinValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "4W8yDuyi_iC", "eeoduCDrXtC", 0.0, 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "ahiVEYXn-Ig", "WpxGSoDbRWj", 5.5, 5.0099999999999998, "5.01\" - 5.5\"", null },
                    { "djrtpYXiSgM", "1pc6gc4RExZ", 4999.0, 4000.0, "4000 - 4999 мА*год ", null },
                    { "f0jf6DqaxSl", "WpxGSoDbRWj", 5.0, 4.5999999999999996, "4.6\" - 5\"", null },
                    { "ISvFivYxEGb", "At5FBTcuf6k", 0.0, 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "MuUtoyyyo7i", "eeoduCDrXtC", 0.0, 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "ODvbBYQVIcR", "At5FBTcuf6k", 0.0, 0.0, "Intel Core i7", "Intel Core i7" },
                    { "RhjV8aJjdOA", "1pc6gc4RExZ", 3999.0, 3000.0, "3000 - 3999 мА*год ", null },
                    { "XnUsz0DjYiP", "WpxGSoDbRWj", 6.0, 5.5, "5.5\" - 6\"", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "4NEOOkvWhAp");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "4W8yDuyi_iC");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "ahiVEYXn-Ig");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "djrtpYXiSgM");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "f0jf6DqaxSl");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "ISvFivYxEGb");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "MuUtoyyyo7i");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "ODvbBYQVIcR");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "RhjV8aJjdOA");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "XnUsz0DjYiP");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "_ku_v5SDYRM");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "00v3Xx2Z-AL");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "0Bewg4AB4no");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "4O-AAWxXqvk");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "4TuQqz4BeUn");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "7LiyrsIOP45");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "8R0WpK54zF7");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "d3vYYWNDR1x");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "dOboUZ_nHtE");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "eYWoWVmXXTi");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "fllBA00AOvj");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "FsKua-kjvon");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "hG8fjgKnvtb");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "iTkm1EMrM_E");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "rcZkNfhApAE");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "RrajEYIlXTw");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "vMP6yQvHMTY");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "WrwxbL4GqF3");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "XTi-sGs6uca");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "yTkQXd_tAeM");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "66lQGoad65G");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "iw77oeYUjhH");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "IYKBQnEbZS1");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "JHMotdJNPMD");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "1pc6gc4RExZ");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "At5FBTcuf6k");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "eeoduCDrXtC");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "WpxGSoDbRWj");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "_IUhE4aXYE7");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "DkjxWIHmxKi");

            migrationBuilder.InsertData(
                table: "tbl_Categories",
                columns: new[] { "Id", "DateCreated", "DateLastEdit", "Description", "Image", "IsDelete", "Name" },
                values: new object[,]
                {
                    { "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7131), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" },
                    { "K_ZQE-j2tw4", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7072), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { "k6gF0CsEuJ-", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7140), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" },
                    { "lw_-LKvVrcH", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7154), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" },
                    { "OGFvKGT57P5", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7143), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "rI1kYKYzDu7", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7149), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { "VYMljuZGttj", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7136), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Name", "PublicName" },
                values: new object[,]
                {
                    { "KL6LqDoQ5SM", "baADvNdQR7R", "BatteryCapacity", "Ємність акумулятора" },
                    { "KZQrd4Xwrn_", "K_ZQE-j2tw4", "GraphicCard", "Дискретна відеокарта" },
                    { "PzjB2De92e_", "baADvNdQR7R", "DisplayDiagonal", "Діагональ екрана" },
                    { "tZ0ImTM8zm8", "K_ZQE-j2tw4", "Processor", "Процесор" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[] { "4MfV3csqIC0", "K_ZQE-j2tw4", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7485), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "4QuVsDU2Zln", 4900, "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7541), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[] { "AHmx3HmwPGQ", "K_ZQE-j2tw4", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7483), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "cDwKeshlgeQ", "OGFvKGT57P5", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7246), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" },
                    { "dgTQ9quhm3z", "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7234), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[,]
                {
                    { "fS97CMXw7YH", "K_ZQE-j2tw4", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7480), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "i-K_IO5HhWT", "K_ZQE-j2tw4", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7490), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "IONp1DJWuOU", "K_ZQE-j2tw4", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7487), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "JJ6MMAALVjR", "rI1kYKYzDu7", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7249), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" },
                    { "jVctM12zvHK", "K_ZQE-j2tw4", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7227), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "ProductEntity", false, "ПК Х123434", 436765, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "l9aktPJblrx", 4800, "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7539), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "LyQB8y0WPUe", 4100, "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7532), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[] { "MI13daCiXAL", "K_ZQE-j2tw4", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7492), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "OYGBt-bnxF4", "k6gF0CsEuJ-", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7242), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "PelHVxQmn8-", 3100, "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7529), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "UXZ85FeIPLG", "VYMljuZGttj", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Utc).AddTicks(7237), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "V04Tq-33pUS", 3600, "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7535), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "WafSv6iL8Kl", 4200, "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7544), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "wDnb3sWx34u", 4600, "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7546), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "ZBLZP_-1_pi", 3900, "baADvNdQR7R", new DateTime(2023, 7, 11, 20, 49, 10, 926, DateTimeKind.Local).AddTicks(7537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "MaxValue", "MinValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "9HySyPlWeVw", "KL6LqDoQ5SM", 4999.0, 4000.0, "4000 - 4999 мА*год ", null },
                    { "9k2MT0KVK7Q", "KZQrd4Xwrn_", 0.0, 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "9Okc93c4auK", "KZQrd4Xwrn_", 0.0, 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "AZ0V4pa5t4r", "tZ0ImTM8zm8", 0.0, 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "E2PBnVYgp6h", "KL6LqDoQ5SM", 3999.0, 3000.0, "3000 - 3999 мА*год ", null },
                    { "gTZ7s5cp8Gq", "PzjB2De92e_", 6.0, 5.5, "5.5\" - 6\"", null },
                    { "NIUc1g4ON6Q", "PzjB2De92e_", 5.0, 4.5999999999999996, "4.6\" - 5\"", null },
                    { "ruS6WnxOWBN", "PzjB2De92e_", 5.5, 5.0099999999999998, "5.01\" - 5.5\"", null },
                    { "ylu6ybC1A1o", "tZ0ImTM8zm8", 0.0, 0.0, "Intel Core i7", "Intel Core i7" }
                });
        }
    }
}
