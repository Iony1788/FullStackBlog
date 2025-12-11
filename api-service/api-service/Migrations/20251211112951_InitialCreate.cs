using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_service.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, "Alice", "React is a JavaScript library for building user interfaces.", new DateTime(2025, 11, 21, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7824), "Introduction to React" },
                    { 2, "Bob", "Learn the basics of .NET Core development.", new DateTime(2025, 11, 22, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7915), "Getting started with .NET Core" },
                    { 3, "Charlie", "EF Core allows you to work with databases using .NET objects.", new DateTime(2025, 11, 23, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7921), "Understanding Entity Framework Core" },
                    { 4, "Diana", "Learn about let, const, arrow functions, and more.", new DateTime(2025, 11, 24, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7926), "JavaScript ES6 Features" },
                    { 5, "Eve", "Manage asynchronous operations easily in C#.", new DateTime(2025, 11, 25, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7932), "C# Async & Await" },
                    { 6, "Frank", "Best practices for designing RESTful APIs.", new DateTime(2025, 11, 26, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7937), "REST API Design" },
                    { 7, "Grace", "Query your collections efficiently using LINQ.", new DateTime(2025, 11, 27, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7942), "Understanding LINQ" },
                    { 8, "Hank", "Learn how DI improves code modularity.", new DateTime(2025, 11, 28, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7948), "Dependency Injection in ASP.NET Core" },
                    { 9, "Ivy", "UseState, UseEffect, and custom hooks explained.", new DateTime(2025, 11, 29, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7953), "React Hooks Overview" },
                    { 10, "Jack", "Write tests for your .NET Core applications.", new DateTime(2025, 11, 30, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7958), "Unit Testing with xUnit" },
                    { 11, "Alice", "Implement client-side routing with React Router.", new DateTime(2025, 12, 1, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7963), "Routing in React" },
                    { 12, "Bob", "How to create and configure middleware in your app.", new DateTime(2025, 12, 2, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7968), "Middleware in ASP.NET Core" },
                    { 13, "Charlie", "Learn how to manage state with Redux or Context API.", new DateTime(2025, 12, 3, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7973), "State Management in React" },
                    { 14, "Diana", "Basic operations with SQL Server using EF Core.", new DateTime(2025, 12, 4, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7978), "Working with SQL Server" },
                    { 15, "Eve", "Compare Blazor and React for frontend development.", new DateTime(2025, 12, 5, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7983), "Blazor vs React" },
                    { 16, "Frank", "Implement authentication with Identity.", new DateTime(2025, 12, 6, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7988), "Authentication in ASP.NET Core" },
                    { 17, "Grace", "Controlled vs uncontrolled components in forms.", new DateTime(2025, 12, 7, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7992), "Forms in React" },
                    { 18, "Hank", "Learn built-in logging providers and how to use them.", new DateTime(2025, 12, 8, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(7997), "Logging in .NET Core" },
                    { 19, "Ivy", "Use error boundaries to handle React component errors.", new DateTime(2025, 12, 9, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(8002), "Error Handling in React" },
                    { 20, "Jack", "Deployment strategies for ASP.NET Core applications.", new DateTime(2025, 12, 10, 15, 29, 51, 74, DateTimeKind.Local).AddTicks(8007), "Deploying ASP.NET Core Apps" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");
        }
    }
}
