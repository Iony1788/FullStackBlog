# FullStackBlog

A full-stack web application for managing blog posts, built with .NET Core for the backend and React for the frontend.
---
## Table of Contents

- [Technologies Used](#technologies-used)  
- [Getting Started](#getting-started)  
  - [Prerequisites](#prerequisites)  
  - [Backend Setup](#backend-setup)  
  - [Frontend Setup](#frontend-setup)  


---

## Technologies Used

- **Backend:** .NET Core / ASP.NET Core Web API  
- **Frontend:** React, JavaScript / TypeScript  
- **Database:** SQL Server 
- **ORM:** Entity Framework Core  
- **Other Tools:** Axios

---

## Getting Started

### Prerequisites

Make sure you have installed:  

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
- [Node.js](https://nodejs.org/) (v20.19.5)  
- [SQL Server]  
- Optional: [Visual Studio / VS Code]  

### Backend Setup

1. Clone the repository:  
   ```bash
   https://github.com/Iony1788/FullStackBlog.git
2. Configure the connection string:
 ```bash
"ConnectionStrings": {
   "BlogDatabase": "Server=YOUR_SERVER;Database=BlogPost;Trusted_Connection=True;MultipleActiveResultSets=true"
 }
 OR
 "ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=BlogDb;User Id=sa;Password=YOUR_PASSWORD;"
}

3. Apply database migrations:
   - Open Package Manager Console in Visual Studio.
   - Make sure the Default project is set to api-service.
   - Run the update-database command: Update-Database
   - 
4. API Documentation (Swagger):
   ```bash
    https://localhost:7151/swagger/index.html

### Frontend (React) Setup
1. In the folder client-app, run the script
   ```bash
   npm install
2. Run app script:
   ```bash
   npm start

