using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StellaAccessories.Services;

namespace StellaAccessories.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {   
        IProductService productService;
        public ProductController(IProductService _productService) { 
            productService = _productService;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            
            return Ok(await productService.getAll());
        }
    }
}
