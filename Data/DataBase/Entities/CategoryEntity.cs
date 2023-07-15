using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using SmartBuyApi.Data.DataBase.Entities;

namespace SmartBuyApi.Data.DataBase.Tables
{
    [Table("tbl_Categories")]
    public class CategoryEntity
    {

        public string Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastEdit { get; set; }
        [Required(ErrorMessage = "Please enter category name."), StringLength(255)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

        public List<FilterName> FilterNames { get; set; }
        public List<ProductEntity> Products { get; set; }
        public CategoryEntity()
        {
            FilterNames = new List<FilterName>();
        }
    }
}
