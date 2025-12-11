using Microsoft.EntityFrameworkCore;
using api_service.Models;
using System;

namespace api_service.Data
{
    public class BlogDatabase : DbContext
    {
        public BlogDatabase(DbContextOptions<BlogDatabase> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost { Id = 1, Title = "Introduction to React", Content = "React is a JavaScript library for building user interfaces.", Author = "Alice", CreatedAt = DateTime.Now.AddDays(-20) },
                new BlogPost { Id = 2, Title = "Getting started with .NET Core", Content = "Learn the basics of .NET Core development.", Author = "Bob", CreatedAt = DateTime.Now.AddDays(-19) },
                new BlogPost { Id = 3, Title = "Understanding Entity Framework Core", Content = "EF Core allows you to work with databases using .NET objects.", Author = "Charlie", CreatedAt = DateTime.Now.AddDays(-18) },
                new BlogPost { Id = 4, Title = "JavaScript ES6 Features", Content = "Learn about let, const, arrow functions, and more.", Author = "Diana", CreatedAt = DateTime.Now.AddDays(-17) },
                new BlogPost { Id = 5, Title = "C# Async & Await", Content = "Manage asynchronous operations easily in C#.", Author = "Eve", CreatedAt = DateTime.Now.AddDays(-16) },
                new BlogPost { Id = 6, Title = "REST API Design", Content = "Best practices for designing RESTful APIs.", Author = "Frank", CreatedAt = DateTime.Now.AddDays(-15) },
                new BlogPost { Id = 7, Title = "Understanding LINQ", Content = "Query your collections efficiently using LINQ.", Author = "Grace", CreatedAt = DateTime.Now.AddDays(-14) },
                new BlogPost { Id = 8, Title = "Dependency Injection in ASP.NET Core", Content = "Learn how DI improves code modularity.", Author = "Hank", CreatedAt = DateTime.Now.AddDays(-13) },
                new BlogPost { Id = 9, Title = "React Hooks Overview", Content = "UseState, UseEffect, and custom hooks explained.", Author = "Ivy", CreatedAt = DateTime.Now.AddDays(-12) },
                new BlogPost { Id = 10, Title = "Unit Testing with xUnit", Content = "Write tests for your .NET Core applications.", Author = "Jack", CreatedAt = DateTime.Now.AddDays(-11) },
                new BlogPost { Id = 11, Title = "Routing in React", Content = "Implement client-side routing with React Router.", Author = "Alice", CreatedAt = DateTime.Now.AddDays(-10) },
                new BlogPost { Id = 12, Title = "Middleware in ASP.NET Core", Content = "How to create and configure middleware in your app.", Author = "Bob", CreatedAt = DateTime.Now.AddDays(-9) },
                new BlogPost { Id = 13, Title = "State Management in React", Content = "Learn how to manage state with Redux or Context API.", Author = "Charlie", CreatedAt = DateTime.Now.AddDays(-8) },
                new BlogPost { Id = 14, Title = "Working with SQL Server", Content = "Basic operations with SQL Server using EF Core.", Author = "Diana", CreatedAt = DateTime.Now.AddDays(-7) },
                new BlogPost { Id = 15, Title = "Blazor vs React", Content = "Compare Blazor and React for frontend development.", Author = "Eve", CreatedAt = DateTime.Now.AddDays(-6) },
                new BlogPost { Id = 16, Title = "Authentication in ASP.NET Core", Content = "Implement authentication with Identity.", Author = "Frank", CreatedAt = DateTime.Now.AddDays(-5) },
                new BlogPost { Id = 17, Title = "Forms in React", Content = "Controlled vs uncontrolled components in forms.", Author = "Grace", CreatedAt = DateTime.Now.AddDays(-4) },
                new BlogPost { Id = 18, Title = "Logging in .NET Core", Content = "Learn built-in logging providers and how to use them.", Author = "Hank", CreatedAt = DateTime.Now.AddDays(-3) },
                new BlogPost { Id = 19, Title = "Error Handling in React", Content = "Use error boundaries to handle React component errors.", Author = "Ivy", CreatedAt = DateTime.Now.AddDays(-2) },
                new BlogPost { Id = 20, Title = "Deploying ASP.NET Core Apps", Content = "Deployment strategies for ASP.NET Core applications.", Author = "Jack", CreatedAt = DateTime.Now.AddDays(-1) }
            );
        }
    }
}
