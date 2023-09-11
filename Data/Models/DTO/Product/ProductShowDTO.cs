using SmartBuyApi.Data.Models.DTO.Category;

namespace SmartBuyApi.Data.Models.DTO.Product
{
	public class ProductShowDTO
	{

		public string Id { get; set; }
		public string Name { get; set; }
		public double Rating { get; set; }
		public int CountOfReviews { get; set; }
		public string ShortDescription { get; set; }
		public int Price { get; set; }
		public string ImageName { get; set; }
		public bool IsLiked { get; set; }
	}
}
