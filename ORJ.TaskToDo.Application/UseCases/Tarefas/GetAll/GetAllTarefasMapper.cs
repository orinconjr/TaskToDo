using AutoMapper;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.GetAll
{
    public sealed class GetAllTarefasMapper : Profile
    {
        public GetAllTarefasMapper()
        {
            CreateMap<Tarefa, TarefaResponse>();
        }
    }
}
