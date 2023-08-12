using SmartBuyApi.Data.Models.DTO;

namespace SmartBuyApi.Data.Services
{
    public interface ICartService
    {
        Task<CartItemDto> AddItem(CartItemToAddDto cartItemToAdd);
        Task<CartItemDto> GetItem(int itemId);
        Task<CartItemDto> RemoveItem(int itemId);
        Task<CartItemDto> UpdateItem(CartItemToUpdateDto cartItemToUpdate);
        Task<List<CartItemDto>> GetAll(int userId);
    }
}