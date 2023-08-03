using Microsoft.EntityFrameworkCore;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.DataBase.Entities.SpecializedProducts;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Factories;

namespace SmartBuyApi.Data.DataBase
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            var factory = new IdFactory(characterCount: 11);
            var globalCategories = new List<GlobalCategoryEntity>()
            {
                new GlobalCategoryEntity(){Id=factory.Generate(), Name="Смартфони та планшети"},
                new GlobalCategoryEntity(){Id=factory.Generate(), Name="Комп’ютери та ноутбуки"},
                new GlobalCategoryEntity(){Id=factory.Generate(), Name="Фото та відео"},
                new GlobalCategoryEntity(){Id=factory.Generate(), Name="Аудіо"},
                new GlobalCategoryEntity(){Id=factory.Generate(), Name="Мультимедіа"},
                new GlobalCategoryEntity(){Id=factory.Generate(), Name="Ігрова техніка"},
                new GlobalCategoryEntity(){Id=factory.Generate(), Name="Побутова техніка"},
                new GlobalCategoryEntity(){Id=factory.Generate(), Name="Електронні гаджети"},
                new GlobalCategoryEntity(){Id=factory.Generate(), Name="Електро-інструменти"},
            };
            modelBuilder.Entity<GlobalCategoryEntity>().HasData(globalCategories);

            var categories = new List<CategoryEntity>
            {
				    new CategoryEntity {
					   Id=factory.Generate(),
					   Name = "Ноутбуки, ультрабуки та мінібуки",
					   IsDelete = false,
					   DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
					   DateLastEdit = default,
					   Description = "description",
					   GlobalCategoryId=globalCategories.ElementAt(1).Id,
				   },
				   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "Смартфони",
                       IsDelete = false,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Description = "description",
                       GlobalCategoryId=globalCategories.ElementAt(0).Id,
                   },
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "Планшети",
                       IsDelete = false,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Description = "description",
                       GlobalCategoryId=globalCategories.ElementAt(0).Id,
                   },
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "Аксесуари для смартфонів і планшетів",
                       IsDelete = false,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Description = "description",
                       GlobalCategoryId=globalCategories.ElementAt(0).Id,
                   },


                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "настільні ПК",
                       IsDelete = false,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Description = "description",
                       GlobalCategoryId=globalCategories.ElementAt(1).Id,
                   },
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "монітори",
                       IsDelete = false,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Description = "description",
                       GlobalCategoryId=globalCategories.ElementAt(1).Id,
                   },
                  
			};

            modelBuilder.Entity<CategoryEntity>().HasData(categories);

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity
                {
                    Id = factory.Generate(),
                    Name = "ПК Х123434",
                    CategoryId = categories.ElementAt(0).Id,
                    IsDelete = false,
                    DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    DateLastEdit = default,
                    Description = "test",
                    ShortDescription = "figna",
                    Price = 436765,

                },
                new ProductEntity
                {
                    Id = factory.Generate(),
                    Name = "iHunt Titan P13000 PRO 2021",
                    CategoryId = categories.ElementAt(1).Id,
                    IsDelete = false,
                    DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    DateLastEdit = default,
                    Description = "Ми представляємо вам найпотужнішу, саму оснащену, ударотривкий та найефективнішу версію смартфона 2021 року від румунської компанії iHunt .",
                    ShortDescription = "figna",
                    Price = 13940,

                },
                new ProductEntity
                {
                    Id = factory.Generate(),
                    Name = "BEKO CNA295K20XP",
                    CategoryId = categories.ElementAt(2).Id,
                    IsDelete = false,
                    DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    DateLastEdit = default,
                    Description = "Холодильники з системою NeoFrost ",
                    ShortDescription = "figna",
                    Price = 10999,

                },
                new ProductEntity
                {
                    Id = factory.Generate(),
                    Name = "Bosch UniversalChain 40",
                    CategoryId = categories.ElementAt(3).Id,
                    IsDelete = false,
                    DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    DateLastEdit = default,
                    Description = "Ланцюгова пила Bosch UniversalChain ",
                    ShortDescription = "figna",
                    Price = 3958
                },
                new ProductEntity
                {
                    Id = factory.Generate(),
                    Name = "Champion Spark 29 19.5 Black-neon yellow-white",
                    CategoryId = categories.ElementAt(4).Id,
                    IsDelete = false,
                    DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    DateLastEdit = default,
                    Description = "Велосипед Champion Spark 29 ",
                    ShortDescription = "figna",
                    Price = 5460
                },
                new ProductEntity
                {
                    Id = factory.Generate(),
                    Name = "Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла",
                    CategoryId = categories.ElementAt(5).Id,
                    IsDelete = false,
                    DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    DateLastEdit = default,
                    Description = "ВНабір паперу офісного Zoom Stora Enso А4 80 г/м2 клас С + 5 пачок по 500 аркушів Біла ",
                    ShortDescription = "figna",
                    Price = 1199
                }
            );


            List<FilterName> filterNames = new List<FilterName>()
            {
                new FilterName(){ Name="GraphicCard", PublicName="Дискретна відеокарта",CategoryId=categories.ElementAt(0).Id},
                new FilterName(){ Name="Processor", PublicName="Процесор",CategoryId=categories.ElementAt(0).Id},
                new FilterName(){ Name="RAM", PublicName="Обсяг оперативної пам'яті",CategoryId=categories.ElementAt(0).Id},

                new FilterName(){ Name="BatteryCapacity", PublicName="Ємність акумулятора", CategoryId=categories.ElementAt(1).Id},
                new FilterName(){ Name="DisplayDiagonal", PublicName="Діагональ екрана",CategoryId=categories.ElementAt(1).Id},
            };

            filterNames.ForEach(x => x.Id = factory.Generate());

            modelBuilder.Entity<FilterName>().HasData(filterNames);



            List<FilterValue> filterValues = new List<FilterValue>()
            {

                new FilterValue(){ StringValue="RTX 3070",PublicValue="GeForce RTX 3070" ,FilterNameId=filterNames.ElementAt(0).Id },
                new FilterValue(){ StringValue="RTX 3060",PublicValue="GeForce RTX 3060" ,FilterNameId=filterNames.ElementAt(0).Id },
                new FilterValue(){ StringValue="RTX 3050",PublicValue="GeForce RTX 3050" ,FilterNameId=filterNames.ElementAt(0).Id },

                new FilterValue(){ StringValue="AMD Ryzen 7",PublicValue="AMD Ryzen 7" ,FilterNameId=filterNames.ElementAt(1).Id },
                new FilterValue(){ StringValue="Intel Core i7",PublicValue="Intel Core i7" ,FilterNameId = filterNames.ElementAt(1).Id },
                new FilterValue(){ StringValue="Intel Core i5",PublicValue="Intel Core i5" ,FilterNameId = filterNames.ElementAt(1).Id },

                new FilterValue(){ MaxValue=3,MinValue=0.2,PublicValue="3 ГБ і менше", FilterNameId = filterNames.ElementAt(2).Id },
                new FilterValue(){ MaxValue=4,MinValue=4,PublicValue="4 ГБ", FilterNameId = filterNames.ElementAt(2).Id },
                new FilterValue(){ MaxValue=8,MinValue=6,PublicValue="6 - 8 ГБ", FilterNameId = filterNames.ElementAt(2).Id },
                new FilterValue(){ MaxValue=12,MinValue=10,PublicValue="10 - 12 ГБ", FilterNameId = filterNames.ElementAt(2).Id },
                new FilterValue(){ MaxValue=24,MinValue=16,PublicValue="16 - 24 ГБ", FilterNameId = filterNames.ElementAt(2).Id },


                new FilterValue(){ MaxValue=3999,MinValue=3000,PublicValue="3000 - 3999 мА*год ", FilterNameId = filterNames.ElementAt(3).Id },
                new FilterValue(){ MaxValue=4999,MinValue=4000,PublicValue="4000 - 4999 мА*год ", FilterNameId = filterNames.ElementAt(3).Id },


                new FilterValue(){ MinValue=4.6,MaxValue=5,PublicValue="4.6\" - 5\"", FilterNameId = filterNames.ElementAt(4).Id },
                new FilterValue(){ MinValue=5.01,MaxValue=5.5,PublicValue="5.01\" - 5.5\"", FilterNameId = filterNames.ElementAt(4).Id },
                new FilterValue(){ MinValue=5.5,MaxValue=6,PublicValue="5.5\" - 6\"", FilterNameId = filterNames.ElementAt(4).Id },

            };

            filterValues.ForEach(x => x.Id = factory.Generate());

            modelBuilder.Entity<FilterValue>().HasData(filterValues);


            List<Laptop> laptops = new List<Laptop>()
            {
                new Laptop(){ Name="Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3070",Processor="Intel Core i7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id,RAM=7},
                new Laptop(){ Name="Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3050",Processor="Intel Core i5", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id,RAM=11},
                new Laptop(){ Name="Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3070",Processor="Intel Core i7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id,RAM=10},
                new Laptop(){ Name="Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3060",Processor="AMD Ryzen 7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id,RAM=12},
                new Laptop(){ Name="Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3050",Processor="AMD Ryzen 7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id,RAM=4},
                new Laptop(){ Name="Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3060",Processor="Intel Core i7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id,RAM=4,

                },
                new Laptop()
                {
                    Name = "Ноутбук HP Pavilion 15-cs3006ur Natural Silver",
                    Description = "Доооооовгий опис",
                    GraphicCard = "Intel Iris Xe Graphics",
                    Processor = "Intel Core i5",
                    ShortDescription = "Екран 15.6\" IPS (1920x1080) Full HD, матовий / Intel Core i5-1135G7 (2.4 - 4.2 ГГц) / RAM 8 ГБ / SSD 256 ГБ " +
                                       "/ Intel Iris Xe Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 1.75 кг / сріблястий",
                    Price = 23999,
                    RAM=16,
                    CategoryId = categories.ElementAt(0).Id,
                },
                new Laptop()
                {
                    Name = "Ноутбук Lenovo IdeaPad 5 Pro 16ACH6",
                    Description = "Доооооовгий опис",
                    GraphicCard = "RTX 3050",
                    Processor = "AMD Ryzen 7",
                    ShortDescription = "Екран 16\" IPS (2560x1600) WQXGA, матовий / AMD Ryzen 7 5800H (3.2 - 4.4 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                                       "/ NVIDIA GeForce RTX 3050, 4 ГБ / без ОД / Wi-Fi / Bluetooth / веб-камера / Windows 11 Home / 2.2 кг / сірий",
                    Price = 29999,
                    RAM=2,
                    CategoryId = categories.ElementAt(0).Id
                },

                new Laptop()
                {
                    Name = "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black",
                    Description = "Доооооовгий опис",
                    GraphicCard = "RTX 3070",
                    Processor = "Intel Core i7",
                    ShortDescription = "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 8 ГБ / SSD 128 ГБ " +
                                       "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний",
                    Price = 28999,
                    RAM=3,
                    CategoryId = categories.ElementAt(0).Id
                },
                new Laptop()
                {
                    Name = "Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black",
                    Description = "Доооооовгий опис",
                    GraphicCard = "RTX 3060",
                    Processor = "Intel Core i5",
                    ShortDescription = "Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                                       "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний",
                    Price = 28999,
                    RAM=1,
                    CategoryId = categories.ElementAt(0).Id,

                }
            };
            laptops.ForEach(x =>
            {
                x.Id = factory.Generate();
                x.DateCreated = DateTime.Now;
            });


            List<Telephone> telephones = new List<Telephone>()
            {
                new Telephone() { Name="Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
                " + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=6.4, BatteryCapacity=3100, CategoryId= categories.ElementAt(1).Id,
                Price=54999},
                new Telephone() { Name="Мобільний телефон Apple i111", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
                " + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=5.6, BatteryCapacity=4100, CategoryId = categories.ElementAt(1).Id,
                Price=54999},
                new Telephone() { Name="Мобільний телефон Apple i222", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
                " + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=5.5, BatteryCapacity=3600, CategoryId = categories.ElementAt(1).Id,
                Price=54999},
                new Telephone() { Name="Мобільний телефон Apple i333313", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
                " + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=5.2, BatteryCapacity=3900, CategoryId = categories.ElementAt(1).Id,
                Price=54999},
                new Telephone() { Name="Мо4444444 4414 Pro Max 128GB Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
                " + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=8.4, BatteryCapacity=4800, CategoryId = categories.ElementAt(1).Id,
                Price=54999},
                new Telephone() { Name="М55555555 Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
                " + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=6.3, BatteryCapacity=4900, CategoryId = categories.ElementAt(1).Id,
                Price=54999},
                new Telephone() { Name="Мобільний 66666666B Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
                " + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=5.1, BatteryCapacity=4200, CategoryId = categories.ElementAt(1).Id,
                Price=54999},
                new Telephone() { Name="Мобіл77777777 28GB Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
                " + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=4.9, BatteryCapacity=4600, CategoryId = categories.ElementAt(1).Id,
                Price=54999},
                new Telephone()
                {
                    Name = "Мобільний телефон Google Pixel 7",
                    Description = "Доооооовгий опис",
                    ShortDescription = "Екран (6.2\", OLED, 2400x1080) / Qualcomm Snapdragon 778G / основна камера: 64 Мп + 16 Мп" +
                                       " + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / eSIM / Android 12",
                    DisplayDiagonal = 6.2,
                    BatteryCapacity = 4500,
                    CategoryId = categories.ElementAt(1).Id,
                    Price = 32999
                },
                new Telephone()
                {
                    Name = "Мобільний телефон Sony Xperia 1 IV",
                    Description = "Доооооовгий опис",
                    ShortDescription = "Екран (6.5\", OLED, 3840x1644) / Qualcomm Snapdragon 888 / основна камера: 64 Мп + 16 Мп" +
                                       " + 12 Мп, фронтальна камера: 10 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12",
                    DisplayDiagonal = 6.5,
                    BatteryCapacity = 5000,
                    CategoryId = categories.ElementAt(1).Id,
                    Price = 74999,
                },
                new Telephone()
                {
                    Name = "Мобільний телефон Xiaomi Mi 12",
                    Description = "Доооооовгий опис",
                    ShortDescription = "Екран (6.81\", OLED, 3200x1440) / Qualcomm Snapdragon 8 Gen 1 / основна квадро-камера: 50 Мп + 12 Мп" +
                                       " + 8 Мп + 2 Мп, фронтальна камера: 32 Мп / 256 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Dual SIM / Android 12",
                    DisplayDiagonal = 6.81,
                    BatteryCapacity = 5000,
                    CategoryId = categories.ElementAt(1).Id,
                    Price = 39999,
                },
                new Telephone()
                {
                    Name = "Мобільний телефон Samsung Galaxy S22",
                    Description = "Доооооовгий опис",
                    ShortDescription = "Екран (6.1\", Dynamic AMOLED 2X, 1080x2400) / Samsung Exynos 2200 / основна квадро-камера: 50 Мп + 12 Мп" +
                                       " + 12 Мп + 12 Мп, фронтальна камера: 10 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / Android 12",
                    DisplayDiagonal = 6.1,
                    BatteryCapacity = 4000,
                    CategoryId = categories.ElementAt(1).Id,
                    Price = 45999,
                }
            };
            telephones.ForEach(x =>
            {
                x.Id = factory.Generate();
                x.DateCreated = DateTime.Now;
            });
            modelBuilder.Entity<Laptop>().HasData(laptops);
            modelBuilder.Entity<Telephone>().HasData(telephones);
            var images = new List<ImageEntity>();
            for (int i = 0, b = 1; i < laptops.Count; i++)
            {
                images.AddRange(new ImageEntity[]
                {
                    new ImageEntity(){Id=factory.Generate(),Name=b+"_1.webp",ProductId=laptops[i].Id,Priority=1},
                    new ImageEntity(){Id=factory.Generate(),Name=b+"_2.webp",ProductId=laptops[i].Id,Priority=2},
                    new ImageEntity(){Id=factory.Generate(),Name=b+"_3.webp",ProductId=laptops[i].Id,Priority=3},
                });
                if (b == 3)
                {
                    b = 1;
                    continue;
                }
                b++;
            }
            for (int i = 0, b = 3; i < telephones.Count; i++)
            {
                images.AddRange(new ImageEntity[]
                {
                    new ImageEntity(){Id=factory.Generate(),Name=b+"_1.webp",ProductId=telephones[i].Id,Priority=1},
                    new ImageEntity(){Id=factory.Generate(),Name=b+"_2.webp",ProductId=telephones[i].Id,Priority=2},
                    new ImageEntity(){Id=factory.Generate(),Name=b+"_3.webp",ProductId=telephones[i].Id,Priority=3},
                });
                if (b == 6)
                {
                    b = 3;
                    continue;
                }
                b++;
            }
            images.AddRange(new ImageEntity[]
            {
                new ImageEntity(){Id=factory.Generate(),Name="laptops.webp",CategoryId=categories[0].Id,GlobalCategoryId=globalCategories[1].Id,Priority=1},
				new ImageEntity(){Id=factory.Generate(),Name="tablets.webp",GlobalCategoryId=globalCategories[0].Id, Priority = 1},
                new ImageEntity(){Id=factory.Generate(),Name="telephones.webp",CategoryId=categories[1].Id, Priority = 1},

			});
            modelBuilder.Entity<ImageEntity>().HasData(images);
        }
    }
}
