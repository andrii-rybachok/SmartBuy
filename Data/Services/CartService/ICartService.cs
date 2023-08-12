using SmartBuyApi.Data.Models.DTO;

namespace SmartBuyApi.Data.Services
{
    public interface ICartService
    {
        Task<CartItemDTO> AddItem(CartItemToAddDTO cartItemToAdd);
        Task<CartItemDTO> GetItem(string itemId);
        Task<CartItemDTO> RemoveItem(string itemId);
        Task<CartItemDTO> UpdateItem(CartItemToUpdateDTO cartItemToUpdate);
        Task<List<CartItemDTO>> GetAll(int userId);
    }
}