using api_service.Models;
using api_service.Services.Implements;
using api_service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_service.Controlers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPost _blogPostService;

        public BlogPostController(IBlogPost blogPostService)
        {
            _blogPostService = blogPostService;
        }


        [HttpGet("blogposts")]
        public async Task<List<BlogPost>> GetAllBlogPosts()
        {
            var listBlogPosts = await _blogPostService.getAllBlogPostAsync();

            return  listBlogPosts;

        }
    }
}
