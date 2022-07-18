using FluentValidation;
using ToDoApi.Contracts.Request;

namespace ToDoApi.Contracts.Validators
{
    public class TodoItemRequestValidator : AbstractValidator<TodoItemRequest>
    {
        public TodoItemRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("The title is required");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("The description is required");

            RuleFor(x => x.EndDate.Day)
                .GreaterThan(DateTime.Today.Day)
                .WithMessage("The date has to be greater than the current date");
        }
    }
}
