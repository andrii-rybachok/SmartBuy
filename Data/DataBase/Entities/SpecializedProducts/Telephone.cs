using SmartBuyApi.Data.DataBase.Tables;

namespace SmartBuyApi.Data.DataBase.Entities.SpecializedProducts
{
	public class Telephone :ProductEntity
	{
		public int BatteryCapacity  { get; set; }
		public double DisplayDiagonal { get; set; }
	}
}
