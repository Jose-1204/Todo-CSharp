using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data;

public class TodoContext : DbContext
{
    // Constructor que recibe opciones de configuración
    public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

    // DbSet representa la tabla "TodoItems" en la base de datos
    public DbSet<TodoItem> TodoItems { get; set; }
}