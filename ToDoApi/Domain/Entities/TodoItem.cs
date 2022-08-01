using ToDoApi.Domain.Enum;
using ToDoApi.Contracts.Response;

namespace ToDoApi.Domain.Entities
{
    public class TodoItem
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public string State { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDone { get; set; }
        public DateTime? UpdateDate { get; set; }

        public TodoItem(string title, string description, DateTime endDate)
        {
            Id = IdIncrementer.GetNextId();
            Title = title;
            Description = description;
            EndDate = endDate;
            State = ItemStates.Todo.ToString();
            CreationDate = DateTime.UtcNow;
        }
    }
}