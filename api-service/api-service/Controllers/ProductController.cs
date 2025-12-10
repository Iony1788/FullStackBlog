using api_service.Models;
using api_service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }


     

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            var createdProduct = await _productService.AddProductAsync(
                product.Name,
                product.Description,
                product.Category,
                product.Price,
                product.ImageUrl
            );

            return CreatedAtAction(nameof(GetAll), createdProduct);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPut("{idProduct}")]
        public async Task<IActionResult> UpdateProduct(int idProduct, [FromBody] Product product)
        {
            var updatedProduct = await _productService.UpdateProductAsync(product, idProduct);

            if (updatedProduct == null)
                return NotFound(new { message = $"Product with id {idProduct} not found." });

            return Ok(updatedProduct);
        }

      

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _productService.DeleteProductAsync(id);

            if (!deleted)
                return NotFound(new { message = $"Product with id {id} not found." });

            return NoContent();
        }
    }
}
