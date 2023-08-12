using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using SmartBuyApi.Data.Models.DTO;

namespace SmartBuyApi.Data.Services
{
    public class CartService : ICartService
    {
        private readonly HttpClient httpClient;

        public CartService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public async Task<CartItemDTO> AddItem(CartItemToAddDTO cartItemToAdd)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync<CartItemToAddDTO>
                    ($"api/Cart/AddItem", cartItemToAdd);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default;
                    }

                    return await response.Content.ReadFromJsonAsync<CartItemDTO>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http Status: {response.StatusCode} Message: {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<CartItemDTO>> GetAll(int userId)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Cart/GetAll/{userId}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return new List<CartItemDTO>();
                    }
                    return await response.Content.ReadFromJsonAsync<List<CartItemDTO>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http Status: {response.StatusCode} Message: {message}");

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<CartItemDTO> GetItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public async Task<CartItemDTO> RemoveItem(int itemId)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"api/Cart/RemoveItem/{itemId}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        return default(CartItemDTO);
                    }
                    return await response.Content.ReadFromJsonAsync<CartItemDTO>();
                }
                else
                {
                    var messsage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Status Code: {response.StatusCode} Message: {messsage}");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CartItemDTO> UpdateItem(CartItemToUpdateDTO cartItemToUpdate)
        {
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(cartItemToUpdate);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json-patch+json");

                var response = await httpClient.PatchAsync($"api/Cart/UpdateItem/{cartItemToUpdate.Id}", content);
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        return default(CartItemDTO);
                    }
                    return await response.Content.ReadFromJsonAsync<CartItemDTO>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}