using SmartBuyApi.Data.DataBase.Tables;

namespace SmartBuyApi.Data.DataBase.Entities.SpecializedProducts
{
	public class Laptop : ProductEntity
	{
		public string Processor { get; set; }
		public string GraphicCard { get; set; }
	}
}
