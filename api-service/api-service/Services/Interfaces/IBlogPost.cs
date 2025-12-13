using api_service.Models;

namespace api_service.Services.Interfaces
{
    public interface IBlogPost
    {
        Task<List<BlogPost>> GetAllBlogPostAsync();

        Task<BlogPost> GetBlogPostByIdAsync(int id);

        Task<BlogPost> EditBlogPostAsync(int id, BlogPost blogPost);

        Task<BlogPost> AddBlogPostAsync(BlogPost blogPost);

        Task<BlogPost> DeleteBlogPostAsync(int id);

        Task<List<BlogPost>> PaginateBlogPostAsync(int page, int pageSize);

    }
}
