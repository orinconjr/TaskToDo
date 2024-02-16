using AutoMapper;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Update
{
    public sealed class UpdateMapper : Profile
    {
        public UpdateMapper()
        {
            CreateMap<UpdateRequest, Tarefa>();
            CreateMap<Tarefa, TarefaResponse>();
        }
    }
}
