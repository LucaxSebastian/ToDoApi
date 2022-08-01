using ToDoApi.Domain.Entities;

namespace ToDoApi.Contracts.Response
{
    public class UpdateTodoResponse
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public string State { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDone { get; set; }
        public DateTime? UpdateDate { get; set; }

        public UpdateTodoResponse(TodoItem todo)
        {
            Id = todo.Id;
            Title = todo.Title;
            Description = todo.Description;
            EndDate = todo.EndDate;
            State = todo.State;
            CreationDate = todo.CreationDate;
            IsDone = todo.IsDone;
            UpdateDate = todo.UpdateDate;
        }
    }
}
