namespace TodoApp.Models;

public class TodoItem
{
    public int Id { get; set; }                  // Clave primaria (PK)
    public string Title { get; set; }             // Título de la tarea
    public bool IsCompleted { get; set; }         // Estado (completada/no)
    public DateTime CreatedAt { get; set; } = DateTime.Now; // Fecha de creación
}