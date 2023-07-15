namespace SmartBuyApi.Data.Models.DTO.Product
{
	public class ProductShowDTO
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string ShortDescription { get; set; }
		public int Price { get; set; }

		// public string Image { get; set; } на будущу реалізацію картинок , бо пока нема її.Як буде то розкоментить і настроїть
	}
}
