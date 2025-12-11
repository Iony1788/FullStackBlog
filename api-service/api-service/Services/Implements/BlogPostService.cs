using api_service.Data;
using api_service.Models;
using api_service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_service.Services.Implements
{
    public class BlogPostService : IBlogPost
    {
        private readonly BlogDatabase _context;

        public BlogPostService(BlogDatabase context)
        {
            _context = context;
        }

        public async Task<List<BlogPost>> getAllBlogPostAsync()
        {
            var listBlogPost = await _context.BlogPosts.ToListAsync();
            return listBlogPost;
        }

    }
}
