using Microsoft.AspNetCore.Mvc;
using ToDoApi.Domain.Entities;
using ToDoApi.Contracts.Request;
using ToDoApi.Contracts.Response;

namespace ToDoApi.Controllers
{
    [ApiController]
    [Route("api/v1/todo")]
    public class ToDoController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateToDo([FromBody] TodoItemRequest request)
        {
            try
            {
                request.Validate();

                var todo = new TodoItem(request.Title, request.Description, request.EndDate);
                TodoList.todoItems.Add(todo);

                return Ok(todo);
            }
            catch(BadHttpRequestException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult<List<TodoItem>> GetAllTodo()
        {
            if (TodoList.todoItems.Count == 0)
            {
                return NoContent();
            }

            return Ok(TodoList.todoItems);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodoById(int id)
        {
            var result = TodoList.todoItems.Find(todo => todo.Id == id);

            if (result == null)
            {
                return NotFound(new { message = "The given Id does not exist in the Todo list." });
            }

            return Ok(result);
        }
    }
}
