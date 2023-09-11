using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.Models.DTO.Image;

namespace SmartBuyApi.Data.Models.DTO.Product
{
	public class ProductDetailDTO
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string ShortDescription { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public List<ImageShowDTO> Images { get; set; }


		public List<Characteristic> Characteristics { get; set; }
		public List<ReviewEntity> Reviews { get; set; }
	}
}
