using TodoApp.Models;

namespace TodoApp.Repositories;

public interface ITodoRepository
{
    Task<List<TodoItem>> GetAllAsync();        // Obtener todas las tareas
    Task<TodoItem> GetByIdAsync(int id);       // Obtener por ID
    Task AddAsync(TodoItem item);              // Agregar nueva tarea
    Task UpdateAsync(TodoItem item);           // Actualizar tarea
    Task DeleteAsync(int id);                  // Eliminar tarea
}