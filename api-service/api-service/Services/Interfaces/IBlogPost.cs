using api_service.Models;

namespace api_service.Services.Interfaces
{
    public interface IBlogPost
    {
        Task<List<BlogPost>> getAllBlogPostAsync();
    }
}
