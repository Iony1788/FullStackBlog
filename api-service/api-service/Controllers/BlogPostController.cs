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
            var listBlogPosts = await _blogPostService.GetAllBlogPostAsync();

            return listBlogPosts;

        }

        [HttpGet("{id}")]
        public async Task<BlogPost> GetBlogPostById(int id)
        {
            var BlogPostId = await _blogPostService.GetBlogPostByIdAsync(id);
            return BlogPostId;
        }


        [HttpPut("editBlogPost/{id}")]
        public async Task<ActionResult<BlogPost>> EditBlogPost(int id, [FromBody] BlogPost blogPost)
        {

            var updatedBlogPost = await _blogPostService.EditBlogPostAsync(id, blogPost);

            if (updatedBlogPost == null)
            {
                return NotFound("Blog post not found");
            }

            return Ok(updatedBlogPost);
        }

        [HttpPost("addBlogPost")]
        public async Task<BlogPost> AddBlogPost([FromBody] BlogPost blogPost)
        {
            var addBlogPost = await _blogPostService.AddBlogPostAsync(blogPost);
            return addBlogPost;

        }

    }
}
