using System.ComponentModel;

namespace ToDoApi.Domain.Enum
{
    public enum State
    {
        [Description("To do")]
        ToDo = 1,

        [Description("In Progress")]
        InProgress = 2,

        [Description("Done")]
        Done = 3,
    }
}
