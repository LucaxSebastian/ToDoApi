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
        public TodoItem PostToDo([FromBody] TodoItemRequest request)
        {
            request.Validate();

            var response = new TodoItem(request.Title, request.Description, request.EndDate);

            return response;
        }
    }
}
