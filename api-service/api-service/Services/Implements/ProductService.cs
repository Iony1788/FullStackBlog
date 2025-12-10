using api_service.Data;
using api_service.Models;
using api_service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_service.Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly ProductDbContext _context;

        public ProductService(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }


        public async Task<Product> AddProductAsync(string name, string description, string category, decimal price, string imageUrl)
        {
            var product = new Product
            {
                Name = name,
                Description = description,
                Category = category,
                Price = price,
                ImageUrl = imageUrl
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product, int idProduct)
        {
            var existingProduct = await _context.Products.FindAsync(idProduct);

            if (existingProduct == null)
                return null;

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Category = product.Category;
            existingProduct.Price = product.Price;
            existingProduct.ImageUrl = product.ImageUrl;

            await _context.SaveChangesAsync();

            return existingProduct;
        }

        public async Task<bool> DeleteProductAsync(int idProduct)
        {
            var product = await _context.Products.FindAsync(idProduct);
            if (product == null)
            {
                return false;
            }

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

            return true;
        }

        public Task<Product> AddProductAsync(string name, string description, decimal price, string imageUrl)
        {
            throw new NotImplementedException();
        }
    }
}