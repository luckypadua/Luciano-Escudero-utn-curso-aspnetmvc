using FluentValidation;
using UTNCurso.Core.DTOs;

namespace UTNCurso.Core.Validations
{
    //#3
    public class TodoItemValidator : AbstractValidator<TodoItemDto>
    {
        public TodoItemValidator()
        {
            RuleFor(ti => ti.Task)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(10).WithMessage("El nombre de la tarea no puede superar los 10 caracteres, no me hagas repetirlo...")
                .NotEmpty().WithMessage("Debe ingresar el nombre de la tarea.");
        }
    }
}
