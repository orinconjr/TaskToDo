using FluentValidation;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Create
{
    public sealed class CreateTarefaValidator : AbstractValidator<CreateTarefaRequest>
    {
        public CreateTarefaValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Active).NotEmpty().NotNull();
        }
    }
}
