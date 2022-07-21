using Microsoft.AspNetCore.Mvc;
using ToDoApi.Domain.Entities;
using ToDoApi.Contracts.Request;

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

                return Ok(new TodoItem(request.Title, request.Description, request.EndDate));
            }
            catch(BadHttpRequestException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
