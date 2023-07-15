﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartBuyApi.Data.DataBase.Tables
{
    [Table("tbl_ProductImages")]
    public class ProductImageEntity
    {

        public string Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool IsDelete { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public  ProductEntity Product { get; set; }
    }
}
