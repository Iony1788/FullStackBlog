using api_service.Data;
using api_service.Models;
using api_service.Services.Implements;
using Microsoft.EntityFrameworkCore;

namespace Tests
{
    public class BlogPostServiceTests
    {
        private BlogDatabase GetDbContext()
        {
            var options = new DbContextOptionsBuilder<BlogDatabase>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            return new BlogDatabase(options);
        }

        [Fact]
        public async Task EditBlogPostAsync_ShouldUpdateBlogPost_WhenBlogExists()
        {
            var context = GetDbContext();

            var existingBlog = new BlogPost
            {
                Id = 1,
                Title = "Old title",
                Content = "Old content",
                Author = "Old author"
            };

            context.BlogPosts.Add(existingBlog);
            await context.SaveChangesAsync();

            var service = new BlogPostService(context);

            var updatedBlog = new BlogPost
            {
                Title = "New title",
                Content = "New content",
                Author = "New author"
            };

            var result = await service.EditBlogPostAsync(1, updatedBlog);

            Assert.NotNull(result);
            Assert.Equal("New title", result.Title);
            Assert.Equal("New content", result.Content);
            Assert.Equal("New author", result.Author);
        }

        [Fact]
        public async Task AddBlogPostAsync_ShouldAddBlogPost()
        {
        
            var context = GetDbContext();
            var service = new BlogPostService(context);

            var newBlog = new BlogPost
            {
                Title = "Test Title",
                Content = "Test Content",
                Author = "Test Author"
            };

           
            var result = await service.AddBlogPostAsync(newBlog);

       
            Assert.NotNull(result);                       
            Assert.Equal("Test Title", result.Title);     
            Assert.Equal("Test Content", result.Content); 
            Assert.Equal("Test Author", result.Author);  

           
            var dbEntry = await context.BlogPosts.FindAsync(result.Id);
            Assert.NotNull(dbEntry);
            Assert.Equal("Test Title", dbEntry.Title);
        }
    }


}