using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    public List<TodoItem> Todos { get; }
        =
        [
            new TodoItem("Lav opgaver", false),
            new TodoItem("Bliv bedre til C# synt", false)
        ];

    [HttpGet]
    public ActionResult<IEnumerable<TodoItem>> Get()
    {
        return Ok(Todos);
    }

    [HttpGet("{id}")]
    public ActionResult<TodoItem> Get(int id)
    {
        if (id < 0 || id > Todos.Count - 1)
        {
            return NotFound();
        }

        return Ok(Todos[id]);
    }
}