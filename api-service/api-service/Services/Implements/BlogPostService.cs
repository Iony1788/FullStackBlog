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

        public async Task<List<BlogPost>> GetAllBlogPostAsync()
        {
            var listBlogPost = await _context.BlogPosts.ToListAsync();
            return listBlogPost;
        }

        public async Task<BlogPost> GetBlogPostByIdAsync(int id)
        {
            var idBlogPost = await _context.BlogPosts.FindAsync(id);

            return idBlogPost;
        }

        public async Task<BlogPost> EditBlogPostAsync(int id, BlogPost blogPost)
        {

            var blogEdit = await _context.BlogPosts.FindAsync(id);

            if (blogEdit == null)
            {
                return null;
            }

            blogEdit.Title = blogPost.Title;
            blogEdit.Content = blogPost.Content;
            blogEdit.Author = blogPost.Author;

            await _context.SaveChangesAsync();

            return blogEdit;
        }

        public async Task<BlogPost> AddBlogPostAsync(BlogPost blogPost)
        {
            var newBlogPost = await _context.BlogPosts.AddAsync(blogPost);

            await _context.SaveChangesAsync();

            return newBlogPost.Entity; ;

        }


        public async Task<BlogPost> DeleteBlogPostAsync(int id)
        {
            var blogPostToDelete = await _context.BlogPosts.FindAsync(id);

            if (blogPostToDelete == null)
            {
                return null; 
            }

            _context.BlogPosts.Remove(blogPostToDelete); 
            await _context.SaveChangesAsync(); 

            return blogPostToDelete;
        }

        public async Task<List<BlogPost>> PaginateBlogPostAsync(int page, int pageSize)
        {
            return await _context.BlogPosts
                .OrderByDescending(b => b.Id) 
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }



    }
}
