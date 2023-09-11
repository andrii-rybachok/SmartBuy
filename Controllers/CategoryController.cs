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
using SmartBuyApi.Data.DataBase.Entities;
using SmartBuyApi.Data.Factories;

namespace SmartBuyAPI.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _iconfiguration;

        public CategoryController(ApplicationDbContext context, IConfiguration iconfigoration, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _iconfiguration = iconfigoration;
        }

        [HttpGet("get")]
        public async Task<ActionResult<IEnumerable<CategoryItemDTO>>> Get()
        {
            var result = await _context.Categories.Select(x => _mapper.Map<CategoryItemDTO>(x)).ToListAsync();
            return Ok(result);
        }
        [HttpGet("get/{id}")] //[HttpGet("get/{id:int}")]
        public async Task<ActionResult<IEnumerable<CategoryItemDTO>>> GetById(string id)
        {
            var result = await _context.Categories.Where(x => x.Id == id).Select(x => _mapper.Map<CategoryItemDTO>(x)).ToListAsync();
            if (result.Count > 0)
            {
                return new ObjectResult(result[0]);
            }
            else { return NotFound(); }
        }

        [HttpPost("create")]
        public async Task<ActionResult<IEnumerable<CategoryCreateDTO>>> Create([FromForm] CategoryCreateDTO model)
        {
            var category = _mapper.Map<CategoryEntity>(model); // CategoryEntity update CategoryCreateDTO

            var factory = new IdFactory(characterCount: 11);
			//category.IsDelete = false;
			category.DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            category.Image = new ImageEntity() { Id=factory.Generate(),Name = ImageHelper.SaveAndGetImageName(model.Image, _iconfiguration) };

            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return Ok(category);
        }
        
        [HttpPut("edit")]
        public async Task<ActionResult<IEnumerable<CategoryEditDTO>>> Edit([FromForm] CategoryEditDTO model)
        {
            var category = await _context.Categories.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (category == null)
                return NotFound();

            ImageHelper.DeleteImage(category.Image.Name);

            category.Name = model.Name;
            //category.DisplayOrder = model.DisplayOrder;
            category.DateLastEdit = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);

            string imageNewName = ImageHelper.SaveAndGetImageName(model.ImageUpload, _iconfiguration);
            category.Image.Name = string.IsNullOrEmpty(imageNewName) ? category.Image.Name : imageNewName;

            //category.Priority = model.Priority;
            category.Description = model.Description;

            await _context.SaveChangesAsync();
            return Ok(category);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var category = await _context.Categories.SingleOrDefaultAsync(x => x.Id == id);
            if (category == null)
                return NotFound();

            ImageHelper.DeleteImage(category.Image.Name);
            
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
