using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBuyApi.Data.DataBase.Tables

{
    [Table("tbl_cart")]
    public class Cart
    {
        public string Id { get; set; }
        public string LastNameUser{ get; set; }
        public List<CartItem> Items { get; set; }
    }
}
