using ToDoApi.Contracts.Validators;

namespace ToDoApi.Contracts.Request
{
    public class TodoItemRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }

        public TodoItemRequest(string title, string description, DateTime endDate)
        {
            Title = title;
            Description = description;
            EndDate = endDate;
        }

        public void Validate()
        {
            var validationResult = new TodoItemRequestValidator().Validate(this);

            if (!validationResult.IsValid)
            {
                throw new BadHttpRequestException($"Invalid request: {validationResult}. Please, try again.");
            }
        }
    }
}
