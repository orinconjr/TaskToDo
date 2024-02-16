using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Update
{
    public sealed record UpdateRequest(Guid Id, string Description, bool Active)
                      : IRequest<TarefaResponse>;
}
