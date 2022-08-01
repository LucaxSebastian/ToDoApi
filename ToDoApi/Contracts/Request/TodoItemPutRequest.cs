using ToDoApi.Contracts.Validator;

namespace ToDoApi.Contracts.Request
{
    public class TodoItemPutRequest : TodoItemRequest
    {
        public DateTime UpdateDate { get; set; }

        public TodoItemPutRequest(string title, string description, DateTime endDate, DateTime updateDate) : base(title, description, endDate)
        {
            UpdateDate = updateDate;
        }
        public void Validate()
        {
            var validationResult = new TodoItemPutRequestValidator().Validate(this);

            if (!validationResult.IsValid)
            {
                throw new BadHttpRequestException($"Invalid request: {validationResult}. Please, try again.");
            }
        }
    }
}
