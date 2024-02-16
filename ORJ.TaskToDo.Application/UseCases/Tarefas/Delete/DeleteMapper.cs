using AutoMapper;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Delete
{
    public sealed class DeleteMapper : Profile
    {
        public DeleteMapper()
        {
            CreateMap<DeleteRequest, Tarefa>();
            CreateMap<Tarefa, TarefaResponse>();
        }
    }
}
