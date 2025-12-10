using api_service.Data;
using api_service.Models;

namespace api_service.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<Product> AddProductAsync(string name, string description,string category, decimal price, string imageUrl);

        Task<Product> UpdateProductAsync(Product product, int idProduct);

        Task<bool> DeleteProductAsync(int idproduct);


    }
}
