using FluentValidation;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Update
{
    public class UpdateValidator : AbstractValidator<UpdateRequest>
    {
        public UpdateValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MaximumLength(200);
        }
    }
}
