using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Registro del DbContext con SQLite
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registro del repositorio (DI)
builder.Services.AddScoped<ITodoRepository, TodoRepository>();

// Habilitar MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuración del Pipeline de Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();      // Archivos estáticos (CSS, JS)
app.UseRouting();
app.UseAuthorization();

// Rutas MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=Index}/{id?}");

app.Run();