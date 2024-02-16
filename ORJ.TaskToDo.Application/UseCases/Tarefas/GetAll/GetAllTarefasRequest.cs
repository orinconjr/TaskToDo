using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.GetAll
{
    public sealed record GetAllTarefasRequest : IRequest<List<TarefaResponse>>;
}
