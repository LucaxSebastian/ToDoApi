using FluentValidation;
using ToDoApi.Contracts.Request;

namespace ToDoApi.Contracts.Validator
{
    public class TodoItemPutRequestValidator : AbstractValidator<TodoItemPutRequest>
    {
        public TodoItemPutRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("The title is required")
                .MinimumLength(5)
                .MaximumLength(20);

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("The description is required")
                .MinimumLength(5)
                .MaximumLength(30);
        }
    }
}
