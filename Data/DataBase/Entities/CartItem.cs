using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBuyApi.Data.DataBase.Tables
{
    [Table("tbl_cartItem")]
    public class CartItem
    {
        public string Id { get; set; }
        public string CartId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
