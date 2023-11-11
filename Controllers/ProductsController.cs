using Microsoft.AspNetCore.Mvc;
using ProductsApp.Models;


namespace ProductsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1},
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M}
        };

        [HttpGet()]
        public IActionResult GetAllProducts()
        {
            return Ok(products);
        }

        
        [HttpGet("{id:int}")]
        public IActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);

            if (product is null)
                return NotFound();

            return Ok(product);
        }
    }
}
