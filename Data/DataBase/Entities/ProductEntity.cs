using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.DataBase.Tables;

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
		[Range(1, 100)]
		public int Dicount { get; set; }

        [Range(1, int.MaxValue)]
        public int Price { get; set; }

        public int ActualPrice => Dicount == 1 ? Price : (int)Math.Round((double)Price-(Price/100*Dicount));

        public double Rating =>Reviews.Count>0? Reviews.Sum(x => x.Rating) / Reviews.Count:0;

        public bool IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastEdit { get; set; }
        

        
        public string? CategoryId { get; set; } 
        
        public CategoryEntity Category { get; set; }
        public SmartUser? UserLike { get; set; }
        public string? UserLikeId { get; set; }
        public List<ImageEntity> Images { get; set; }
        public List<ReviewEntity> Reviews { get; set; }

        public ProductEntity()
        {
			Reviews = new List<ReviewEntity>();
            Images = new List<ImageEntity>();
        }
	}
}
