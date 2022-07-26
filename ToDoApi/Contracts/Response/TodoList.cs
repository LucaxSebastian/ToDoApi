using ToDoApi.Domain.Entities;

namespace ToDoApi.Contracts.Response
{
    public static class TodoList
    {
        public static List<TodoItem> TodoItems = new();

        public static bool IsEmptyTodoItems()
        {
            return TodoItems.Count == 0;
        }
    }
}
