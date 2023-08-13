namespace SmartBuyAPI.Controllers
{
    [Route("api/[controller]")]
        [ApiController]
    public class CartController : Controller
    {
            private readonly ICartService _service;
            public CartController(ICartService service)
            {
                _service = service;
            }

            [HttpGet]
            public IActionResult Get()
            {
                var items = _service.GetAll();
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
            public IActionResult Post([FromBody] CartItem value)
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
}