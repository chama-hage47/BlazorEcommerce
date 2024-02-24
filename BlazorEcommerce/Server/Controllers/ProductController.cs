using BlazorEcommerce.Server.Services.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Controllers
 {
	[Route("api/[controller]")]//[Route("[controller]")]same meaning
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;//this needs to be called

		public ProductController(IProductService productService)
		{
			//this.context = context;this is ok but not preferrable so redefining in order to use datacontext
			_productService = productService;
			//context = _context;same as above
		}

		[HttpGet]
		//public async Task<IActionResult> GetProduct() this will only give database for controller weather
		public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()//modified, gives database for product list 
		{
			var result = await _productService.GetProductsAsync();
			return Ok(result);

		}
 }
	}
