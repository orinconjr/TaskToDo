using FluentValidation;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Delete
{
    public class DeleteValidator :
    AbstractValidator<DeleteRequest>
    {
        public DeleteValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
