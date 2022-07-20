using System.ComponentModel;

namespace ToDoApi.Domain.Enum
{
    public enum ItemStates
    {
        [Description("Todo")]
        Todo = 1,

        [Description("In Progress")]
        InProgress = 2,

        [Description("Done")]
        Done = 3,
    }
}
