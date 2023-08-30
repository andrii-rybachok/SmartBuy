using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBuyApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "B4MxOrx3inZ", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4037), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Спорт і захоплення" },
                    { "B8Z-CI6Guhy", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4029), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Побутова техніка" },
                    { "EuYbPpvWi2T", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4033), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Дача, сад, город" },
                    { "F66lZgzPcE2", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4043), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Офіс, школа, книги" },
                    { "hStiV9RgXB-", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(3962), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Комп'ютери та ноутбуки" },
                    { "TBAqOJ-8oz_", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4048), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description test", "1.jpg", false, "test" },
                    { "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4023), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "1.jpg", false, "Смартфони" }
                });

            migrationBuilder.InsertData(
                table: "tbl_FilterNames",
                columns: new[] { "Id", "CategoryId", "Name", "PublicName" },
                values: new object[,]
                {
                    { "EMvKCf7TKpn", "U0IblcRLrtH", "BatteryCapacity", "Ємність акумулятора" },
                    { "o7pz7ATRErp", "hStiV9RgXB-", "Processor", "Процесор" },
                    { "otQJ_WYxPvD", "hStiV9RgXB-", "GraphicCard", "Дискретна відеокарта" },
                    { "sxBGSjt3i02", "U0IblcRLrtH", "DisplayDiagonal", "Діагональ екрана" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[,]
                {
                    { "-yPlxbdVrzl", "hStiV9RgXB-", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4460), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "0HtV6W5IN3N", "hStiV9RgXB-", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "23hx5zgS1ef", 4100, "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4508), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5999999999999996, false, "Мобільний телефон Apple i111", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[,]
                {
                    { "5damgi7hSfo", "hStiV9RgXB-", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4457), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "5V9EIr9e9N6", "hStiV9RgXB-", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4465), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" },
                    { "Aaww7rMuXVF", "hStiV9RgXB-", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4454), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3060", false, "Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "AMD Ryzen 7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "BVYc8CBbc7K", "F66lZgzPcE2", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4163), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ", "ProductEntity", false, "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла", 1199, "figna" },
                    { "DeWSEKq4t4o", "B4MxOrx3inZ", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4159), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Велосипед Champion Spark 29 ", "ProductEntity", false, "Champion Spark 29 19.5 Black-neon yellow-white", 5460, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "g-EyMhvAOjY", 4900, "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4518), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.2999999999999998, false, "М55555555 Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "J23nfGbAWV0", 4600, "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4523), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 4.9000000000000004, false, "Мобіл77777777 28GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "K51NDu9SoIj", 3900, "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4513), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.2000000000000002, false, "Мобільний телефон Apple i333313", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "GraphicCard", "IsDelete", "Name", "Price", "Processor", "ShortDescription" },
                values: new object[] { "K71GaoRcAyL", "hStiV9RgXB-", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4450), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Laptop", "RTX 3070", false, "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", 28999, "Intel Core i7", "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "kb-a5kORI_N", "EuYbPpvWi2T", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4154), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ланцюгова пила Bosch UniversalChain ", "ProductEntity", false, "Bosch UniversalChain 40", 3958, "figna" });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "nXlblVUYU9M", 3100, "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4506), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 6.4000000000000004, false, "Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "PgSRpgsa5gk", 4800, "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4515), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 8.4000000000000004, false, "Мо4444444 4414 Pro Max 128GB Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" },
                    { "TADMdOwCegW", 3600, "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4510), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.5, false, "Мобільний телефон Apple i222", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "ufNg4vuvV91", "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4143), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .", "ProductEntity", false, "iHunt Titan P13000 PRO 2021", 13940, "figna" },
                    { "VH9GLj-1NG_", "hStiV9RgXB-", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4135), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "ProductEntity", false, "ПК Х123434", 436765, "figna" },
                    { "WHq0CtUXYQ2", "B8Z-CI6Guhy", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Utc).AddTicks(4148), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Холодильники з системою NeoFrost ", "ProductEntity", false, "BEKO CNA295K20XP", 10999, "figna" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Products",
                columns: new[] { "Id", "BatteryCapacity", "CategoryId", "DateCreated", "DateLastEdit", "Description", "Discriminator", "DisplayDiagonal", "IsDelete", "Name", "Price", "ShortDescription" },
                values: new object[] { "YxPgv8LGUYO", 4200, "U0IblcRLrtH", new DateTime(2023, 8, 30, 7, 11, 37, 643, DateTimeKind.Local).AddTicks(4521), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Доооооовгий опис", "Telephone", 5.0999999999999996, false, "Мобільний 66666666B Deep Purple", 54999, "Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16" });

            migrationBuilder.InsertData(
                table: "tbl_FilterValues",
                columns: new[] { "Id", "FilterNameId", "MaxValue", "MinValue", "PublicValue", "StringValue" },
                values: new object[,]
                {
                    { "_5Nhy7Dm-AR", "sxBGSjt3i02", 6.0, 5.5, "5.5\" - 6\"", null },
                    { "3zoRNRPJxdm", "o7pz7ATRErp", 0.0, 0.0, "AMD Ryzen 7", "AMD Ryzen 7" },
                    { "5Jx6pPyrZVT", "o7pz7ATRErp", 0.0, 0.0, "Intel Core i7", "Intel Core i7" },
                    { "5lbF7K3TNev", "otQJ_WYxPvD", 0.0, 0.0, "GeForce RTX 3070", "RTX 3070" },
                    { "7CtdFW-sRVx", "otQJ_WYxPvD", 0.0, 0.0, "GeForce RTX 3060", "RTX 3060" },
                    { "a2hui9-eO7S", "EMvKCf7TKpn", 4999.0, 4000.0, "4000 - 4999 мА*год ", null },
                    { "b6BCdMHbVhL", "EMvKCf7TKpn", 3999.0, 3000.0, "3000 - 3999 мА*год ", null },
                    { "R1E0TbXRfYA", "sxBGSjt3i02", 5.0, 4.5999999999999996, "4.6\" - 5\"", null },
                    { "tVu_Qx8397d", "sxBGSjt3i02", 5.5, 5.0099999999999998, "5.01\" - 5.5\"", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "TBAqOJ-8oz_");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "_5Nhy7Dm-AR");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "3zoRNRPJxdm");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "5Jx6pPyrZVT");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "5lbF7K3TNev");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "7CtdFW-sRVx");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "a2hui9-eO7S");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "b6BCdMHbVhL");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "R1E0TbXRfYA");

            migrationBuilder.DeleteData(
                table: "tbl_FilterValues",
                keyColumn: "Id",
                keyValue: "tVu_Qx8397d");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "-yPlxbdVrzl");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "0HtV6W5IN3N");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "23hx5zgS1ef");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "5damgi7hSfo");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "5V9EIr9e9N6");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "Aaww7rMuXVF");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "BVYc8CBbc7K");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "DeWSEKq4t4o");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "g-EyMhvAOjY");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "J23nfGbAWV0");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "K51NDu9SoIj");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "K71GaoRcAyL");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "kb-a5kORI_N");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "nXlblVUYU9M");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "PgSRpgsa5gk");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "TADMdOwCegW");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "ufNg4vuvV91");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "VH9GLj-1NG_");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "WHq0CtUXYQ2");

            migrationBuilder.DeleteData(
                table: "tbl_Products",
                keyColumn: "Id",
                keyValue: "YxPgv8LGUYO");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "B4MxOrx3inZ");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "B8Z-CI6Guhy");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "EuYbPpvWi2T");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "F66lZgzPcE2");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "EMvKCf7TKpn");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "o7pz7ATRErp");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "otQJ_WYxPvD");

            migrationBuilder.DeleteData(
                table: "tbl_FilterNames",
                keyColumn: "Id",
                keyValue: "sxBGSjt3i02");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "hStiV9RgXB-");

            migrationBuilder.DeleteData(
                table: "tbl_Categories",
                keyColumn: "Id",
                keyValue: "U0IblcRLrtH");

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
    }
}
