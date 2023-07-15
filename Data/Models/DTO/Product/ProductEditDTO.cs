using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SmartBuyApi.Data.Models.DTO.Product
{
    public class ProductEditDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public IFormFile ImageUpload { get; set; }
        public string? CategoryId { get; set; }

    }
}
