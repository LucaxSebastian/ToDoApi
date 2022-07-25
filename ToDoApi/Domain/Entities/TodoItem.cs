using ToDoApi.Domain.Enum;
using ToDoApi.Contracts.Response;

namespace ToDoApi.Domain.Entities
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public string State { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDone { get; set; }

        public TodoItem(string title, string description, DateTime endDate)
        {
            Id = IdGenerator.GetNextId();
            Title = title;
            Description = description;
            EndDate = endDate;
            State = ItemStates.Todo.ToString();
            CreationDate = DateTime.UtcNow;
        }
    }
}