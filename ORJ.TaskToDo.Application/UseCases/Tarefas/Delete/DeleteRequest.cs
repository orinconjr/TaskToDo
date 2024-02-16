using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Delete
{
    public sealed record DeleteRequest(Guid Id)
                  : IRequest<TarefaResponse>;
}
