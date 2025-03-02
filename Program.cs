using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configuración de la base de datos SQLite
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registro del repositorio
builder.Services.AddScoped<ITodoRepository, TodoRepository>();

// Configuración de MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuración del pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=Index}/{id?}");

app.Run();