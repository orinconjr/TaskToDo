using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.GetById
{
    public sealed record GetRequest(Guid Id) : IRequest<TarefaResponse>;
}
