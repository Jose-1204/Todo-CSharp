📋 Todo List App with ASP.NET Core MVC
A web application to manage tasks (CRUD) using ASP.NET Core MVC, SQLite, and the Repository Pattern. Perfect for learning .NET Core basics, MVC architecture, and best practices.

🛠️ Technologies Used
This project is built with the following technologies:
Backend: ASP.NET Core MVC for handling HTTP requests and business logic, Entity Framework Core for database management, and SQLite as the lightweight database.
Frontend: Razor Views for dynamic HTML generation, HTML5 for structure, and Bootstrap 5 for responsive and modern styling.
Patterns: Repository Pattern for clean data access, Dependency Injection for decoupling components, and MVC architecture for separation of concerns.
Tools: .NET CLI for project management, Git for version control, and Visual Studio Code as the primary code editor.

Methodologies and Best Practices
Repository Pattern
MVC Architecture
Dependency Injection
Entity Framework Core 

🚀 How to Run the Project
Clone the repository:
git clone https://github.com/Jose-1204/Todo-CSharp.git
cd todo-app

Restore dependencies and run migrations:
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update

Start the application:
dotnet run
Open in your browser: https://localhost:5001
