using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Repositories;

public class TodoRepository : ITodoRepository
{
    private readonly TodoContext _context;

    public TodoRepository(TodoContext context)
    {
        _context = context;
    }

    public async Task<List<TodoItem>> GetAllAsync() => await _context.TodoItems.ToListAsync();

    public async Task<TodoItem> GetByIdAsync(int id) => await _context.TodoItems.FindAsync(id);

    public async Task AddAsync(TodoItem item)
    {
        await _context.TodoItems.AddAsync(item);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TodoItem item)
    {
        _context.TodoItems.Update(item);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var item = await GetByIdAsync(id);
        _context.TodoItems.Remove(item);
        await _context.SaveChangesAsync();
    }
}