using SmartBuyApi.DataBase.Tables;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBuyApi.Data.DataBase.Tables

{
    [Table("tbl_cart")]
    public class Cart
    {
        public string Id { get; set; }
        public string UserId{ get; set; }
        public List<CartItem> Items { get; set; }
    }
}
