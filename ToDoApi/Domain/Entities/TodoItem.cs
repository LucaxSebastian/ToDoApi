using System;
using System.Collections.Generic;
using ToDoApi.Domain.Enum;

namespace ToDoApi.Domain.Entities
{
    class TodoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public State State { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }

        public TodoItem(string title, string description, State state, bool isDone, DateTime creationDate, DateTime endDate)
        {
            Title = title;
            Description = description;
            State = state;
            IsDone = isDone;
            CreationDate = creationDate;
            EndDate = endDate;
        }


    }
}
