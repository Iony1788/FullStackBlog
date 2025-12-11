using api_service.Services.Implements;
using api_service.Services.Interfaces;
using api_service.Data;
using Microsoft.EntityFrameworkCore;

namespace api_service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddDbContext<BlogDatabase>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("BlogDatabase")));

      
            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IBlogPost, BlogPostService>();

            var app = builder.Build();

         
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
