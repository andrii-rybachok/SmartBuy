using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Drawing;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SmartBuyAPI.Helpers;
using SmartBuyApi.Data.DataBase.Tables;
using SmartBuyApi.Data.Models.DTO.Category;
using SmartBuyApi.DataBase;
using SmartBuyApi.Data.Services;
using SmartBuyApi.Data.Models.DTO;

namespace SmartBuyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _service;
        public CartController(ICartService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get(int userId)
        {
            var items = _service.GetAll(userId);
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var item = _service.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CartItemAddDTO value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var item = _service.AddItem(value);
            return CreatedAtAction("Get", new { id = item.Id }, item);
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(string id)
        {
            var existingItem = _service.GetItem(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _service.RemoveItem(id);
            return NoContent();
        }
    }

}
