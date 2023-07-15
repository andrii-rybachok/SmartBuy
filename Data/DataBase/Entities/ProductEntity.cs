using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SmartBuyApi.Data.DataBase.Tables
{
    [Table("tbl_Products")]
    public class ProductEntity
    {
        public string Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(500)]
        public string ShortDescription { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        [Range(1, int.MaxValue)]
        public int Price { get; set; }
        public bool IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastEdit { get; set; }
        

        
        public string? CategoryId { get; set; } 
        
        public CategoryEntity Category { get; set; }

		public List<ProductImageEntity> Images { get; set; }
        public ProductEntity()
        {
            Images = new List<ProductImageEntity>();
        }
	}
}
