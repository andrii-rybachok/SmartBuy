using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartBuyApi.Data.Models.DTO.Product;
using SmartBuyApi.DataBase;

namespace SmartBuyApi.Data.Services.ProductService
{
	public class ProductService : IProductService
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public ProductService(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<List<ProductShowDTO>> GetLastSeenProducts(string[] productIds)
		{
			var products=new List<ProductShowDTO>();
			foreach (var id in productIds)
			{
				var product = _context.Products.FirstOrDefaultAsync(x => x.Id == id);
				if (product != null)
				{
					products.Add(_mapper.Map<ProductShowDTO>(product));
				}
			}
			return products;
		}

		public List<ProductShowDTO> GetPromotedProducts()
		{
			var products= _context.Products.Include(x=>x.Comments).Include(x=>x.Images).Where(x=>x.Dicount>1).Take(10).ToList();
			if (products.Count > 0)
			{
				return _mapper.Map<List<ProductShowDTO>>(products);
			}
			products = _context.Products.Include(x => x.Comments).Include(x => x.Images).Take(10).ToList();
			return _mapper.Map<List<ProductShowDTO>>(products);
		}
	}
}
