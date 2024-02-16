using FluentValidation;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.GetById
{
    public class GetValidator : AbstractValidator<GetRequest>
    {
        public GetValidator()
        {
            //Sem validar
        }
    }
}
