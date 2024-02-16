using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Create
{
    public sealed record CreateTarefaRequest(string Description, bool Active) : IRequest<TarefaResponse>;
}
