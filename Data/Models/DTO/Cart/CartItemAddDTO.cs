namespace SmartBuyApi.Data.Models.DTO
{
    public class CartItemAddDTO
    {
        public string CartId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
