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
                TodoList.TodoItems.Add(todo);

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
            if (TodoList.IsEmptyTodoItems())
            {
                return NoContent();
            }

            return Ok(TodoList.TodoItems);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodoById(int id)
        {
            var result = TodoList.TodoItems.Find(todo => todo.Id == id);

            if (result is null)
            {
                return NotFound(new { message = "The given Id does not exist in the Todo list." });
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTodoById(int id, [FromBody] TodoItemPutRequest update)
        {
            try
            {
                update.Validate();

                var todo = TodoList.TodoItems.Find(element => element.Id == id);

                if (todo is null)
                {
                    return NotFound("The given id does not exist. Enter a valid Id to update information");
                }

                todo.Title = update.Title;
                todo.Description = update.Description;
                todo.UpdateDate = DateTime.Now;

                return Ok(new UpdateTodoResponse(todo));
            }
            catch (BadHttpRequestException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
