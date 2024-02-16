using FluentValidation;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.GetAll
{
    public class GetAllTarefasValidator : AbstractValidator<GetAllTarefasRequest>
    {
        public GetAllTarefasValidator()
        {
            //Sem validar
        }
    }
}
