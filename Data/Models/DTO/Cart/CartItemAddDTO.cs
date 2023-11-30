namespace SmartBuyApi.Data.Models.DTO
{
    public class CartItemAddDTO
    {
        public required string CartId { get; set; }
        public required string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
