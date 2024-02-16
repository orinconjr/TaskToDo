using AutoMapper;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Create
{
    public sealed class CreateTarefaMapper : Profile
    {
        public CreateTarefaMapper()
        {
            CreateMap<CreateTarefaRequest, Tarefa>();
            CreateMap<Tarefa, TarefaResponse>();
        }
    }
}
