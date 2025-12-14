using api_service.Data;
using api_service.Middleware;
using api_service.Services.Implements;
using api_service.Services.Interfaces;
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

            builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
            builder.Services.AddProblemDetails();


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IBlogPost, BlogPostService>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("ReactPolicy", builder =>
                {
                    builder.WithOrigins("http://localhost:3000") 
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });

            var app = builder.Build();

            app.UseCors("ReactPolicy");


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseExceptionHandler();
            app.MapControllers();

            app.Run();
        }
    }
}
