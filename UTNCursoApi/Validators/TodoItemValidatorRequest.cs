using FluentValidation;
using UTNCurso.Core.DTOs;

namespace UTNCursoApi.Validators
{
    public class TodoItemValidatorRequest : AbstractValidator<TodoItemDto>
    {
        public TodoItemValidatorRequest()
        {
            RuleFor(ti => ti.Task)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(10).WithMessage("El nombre de la tarea no puede superar los 10 caracteres")
                .NotEmpty().WithMessage("Debe ingresar el nombre de la tarea.");
        }
    }
}
