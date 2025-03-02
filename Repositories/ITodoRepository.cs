using TodoApp.Models;

namespace TodoApp.Repositories;

public interface ITodoRepository
{
    Task<List<TodoItem>> GetAllAsync();
    Task<TodoItem> GetByIdAsync(int id);
    Task AddAsync(TodoItem item);
    Task UpdateAsync(TodoItem item);
    Task DeleteAsync(int id);
}