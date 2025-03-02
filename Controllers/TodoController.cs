using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Repositories;

namespace TodoApp.Controllers;

public class TodoController : Controller
{
    private readonly ITodoRepository _repository;

    public TodoController(ITodoRepository repository)
    {
        _repository = repository;
    }

    // GET: Todo
    public async Task<IActionResult> Index()
    {
        return View(await _repository.GetAllAsync());
    }

    // GET: Todo/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Todo/Create
    [HttpPost]
    public async Task<IActionResult> Create(TodoItem item)
    {
        if (ModelState.IsValid)
        {
            await _repository.AddAsync(item);
            return RedirectToAction(nameof(Index));
        }
        return View(item);
    }

    // GET: Todo/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var item = await _repository.GetByIdAsync(id);
        if (item == null) return NotFound();
        return View(item);
    }

    // POST: Todo/Edit/5
    [HttpPost]
    public async Task<IActionResult> Edit(int id, TodoItem item)
    {
        if (id != item.Id) return NotFound();

        if (ModelState.IsValid)
        {
            await _repository.UpdateAsync(item);
            return RedirectToAction(nameof(Index));
        }
        return View(item);
    }

    // GET: Todo/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _repository.GetByIdAsync(id);
        if (item == null) return NotFound();
        return View(item);
    }

    // POST: Todo/Delete/5
    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _repository.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }
}