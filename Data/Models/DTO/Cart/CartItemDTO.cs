using System;
using System.Collections.Generic;
using System.Text;
using SmartBuyApi.Data.Models.DTO.Product;

namespace SmartBuyApi.Data.Models.DTO
{
    public class CartItemDTO
    {
        public string Id { get; set; }
        public string CartId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductShortDescription { get; set; }
        public string ProductImageUrl { get; set; }
        public string? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrices { get; set; }
        public int Quantity { get; set; }
    }
}