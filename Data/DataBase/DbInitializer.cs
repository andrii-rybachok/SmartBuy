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
			var categories = new List<CategoryEntity>
            {
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "Комп'ютери та ноутбуки",
                       //Priority = 1,
                       IsDelete = false,
                       //DisplayOrder = 10,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Image = "1.jpg",
                       Description = "description", },
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "Смартфони",
                       //Priority = 1,
                       IsDelete = false,
                      //DisplayOrder = 10,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Image = "1.jpg",
                       Description = "description", },
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "Побутова техніка",
                       //Priority = 1,
                       IsDelete = false,
                       //DisplayOrder = 10,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Image = "1.jpg",
                       Description = "description", },
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "Дача, сад, город",
                       //Priority = 1,
                       IsDelete = false,
                       //DisplayOrder = 10,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Image = "1.jpg",
                       Description = "description", },
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "Спорт і захоплення",
                       //Priority = 1,
                       IsDelete = false,
                       //DisplayOrder = 10,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Image = "1.jpg",
                       Description = "description", },
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "Офіс, школа, книги",
                       //Priority = 1,
                       IsDelete = false,
                       //DisplayOrder = 10,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Image = "1.jpg",
                       Description = "description", },
                   new CategoryEntity {
                       Id=factory.Generate(),
                       Name = "test",
                       //Priority = 1,
                       IsDelete = false,
                       //DisplayOrder = 10,
                       DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                       DateLastEdit = default,
                       Image = "1.jpg",
                       Description = "description test", }
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
                new FilterName(){ Name="BatteryCapacity", PublicName="Ємність акумулятора", CategoryId=categories.ElementAt(1).Id},
                new FilterName(){ Name="DisplayDiagonal", PublicName="Діагональ екрана",CategoryId=categories.ElementAt(1).Id},
            };

            filterNames.ForEach(x => x.Id = factory.Generate());

            modelBuilder.Entity<FilterName>().HasData(filterNames);



		    List <FilterValue> filterValues = new List<FilterValue>()
            {

                new FilterValue(){ StringValue="RTX 3070",PublicValue="GeForce RTX 3070" ,FilterNameId=filterNames.ElementAt(0).Id },
                new FilterValue(){ StringValue="RTX 3060",PublicValue="GeForce RTX 3060" ,FilterNameId=filterNames.ElementAt(0).Id },

                new FilterValue(){ StringValue="AMD Ryzen 7",PublicValue="AMD Ryzen 7" ,FilterNameId=filterNames.ElementAt(1).Id },
                new FilterValue(){ StringValue="Intel Core i7",PublicValue="Intel Core i7" ,FilterNameId = filterNames.ElementAt(1).Id },

                new FilterValue(){ MaxValue=3999,MinValue=3000,PublicValue="3000 - 3999 мА*год ", FilterNameId = filterNames.ElementAt(2).Id },
                new FilterValue(){ MaxValue=4999,MinValue=4000,PublicValue="4000 - 4999 мА*год ", FilterNameId = filterNames.ElementAt(2).Id },


                new FilterValue(){ MinValue=4.6,MaxValue=5,PublicValue="4.6\" - 5\"", FilterNameId = filterNames.ElementAt(3).Id },
                new FilterValue(){ MinValue=5.01,MaxValue=5.5,PublicValue="5.01\" - 5.5\"", FilterNameId = filterNames.ElementAt(3).Id },
                new FilterValue(){ MinValue=5.5,MaxValue=6,PublicValue="5.5\" - 6\"", FilterNameId = filterNames.ElementAt(3).Id },

            };

            filterValues.ForEach(x => x.Id = factory.Generate());

			modelBuilder.Entity<FilterValue>().HasData(filterValues);


			List<Laptop> laptops = new List<Laptop>()
            {
                new Laptop(){ Name="Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3070",Processor="Intel Core i7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id},
                new Laptop(){ Name="Ноутбук Acer22222 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3060",Processor="AMD Ryzen 7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id},
                new Laptop(){ Name="Ноутбук Acer333333 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3070",Processor="Intel Core i7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id},
                new Laptop(){ Name="Ноутбук Acer44444444444 Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3060",Processor="AMD Ryzen 7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id},
                new Laptop(){ Name="Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3070",Processor="AMD Ryzen 7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id},
                new Laptop(){ Name="Ноутбук Acer Aspire 7 A715-42G-R3EZ (NH.QBFEU.00C) Charcoal Black", Description="Доооооовгий опис",GraphicCard="RTX 3060",Processor="Intel Core i7", ShortDescription="Екран 15.6\" IPS (1920x1080) Full HD, матовий / AMD Ryzen 5 5500U (2.1 - 4.0 ГГц) / RAM 16 ГБ / SSD 512 ГБ " +
                "/ nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / без ОС / 2.15 кг / чорний", Price=28999, CategoryId=categories.ElementAt(0).Id},
            };
            laptops.ForEach(x =>
            {
                x.Id = factory.Generate();
                x.DateCreated = DateTime.Now;
            });
			modelBuilder.Entity<Laptop>().HasData(laptops);


			List<Telephone> telephones = new List<Telephone>()
            {
                new Telephone() { Name="Мобільний телефон Apple iPhone 14 Pro Max 128GB Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
                " + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=6.4, BatteryCapacity=3100, CategoryId= categories.ElementAt(1).Id,
                Price=54999,},
				new Telephone() { Name="Мобільний телефон Apple i111", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
				" + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=5.6, BatteryCapacity=4100, CategoryId = categories.ElementAt(1).Id,
				Price=54999,},
				new Telephone() { Name="Мобільний телефон Apple i222", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
				" + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=5.5, BatteryCapacity=3600, CategoryId = categories.ElementAt(1).Id,
				Price=54999,},
				new Telephone() { Name="Мобільний телефон Apple i333313", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
				" + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=5.2, BatteryCapacity=3900, CategoryId = categories.ElementAt(1).Id,
				Price=54999,},
				new Telephone() { Name="Мо4444444 4414 Pro Max 128GB Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
				" + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=8.4, BatteryCapacity=4800, CategoryId = categories.ElementAt(1).Id,
				Price=54999,},
				new Telephone() { Name="М55555555 Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
				" + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=6.3, BatteryCapacity=4900, CategoryId = categories.ElementAt(1).Id,
				Price=54999,},
				new Telephone() { Name="Мобільний 66666666B Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
				" + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=5.1, BatteryCapacity=4200, CategoryId = categories.ElementAt(1).Id,
				Price=54999,},
				new Telephone() { Name="Мобіл77777777 28GB Deep Purple", Description="Доооооовгий опис",ShortDescription="Екран (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A16 Bionic / основна квадро-камера: 48 Мп + 12 Мп" +
				" + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / 128 ГБ вбудованої пам'яті / 3G / LTE / 5G / GPS / Nano-SIM / iOS 16", DisplayDiagonal=4.9, BatteryCapacity=4600, CategoryId = categories.ElementAt(1).Id,
				Price=54999,},
			};
            telephones.ForEach(x =>
			{
				x.Id = factory.Generate();
				x.DateCreated = DateTime.Now;
			});
			modelBuilder.Entity<Telephone>().HasData(telephones);

		}
	}
}
