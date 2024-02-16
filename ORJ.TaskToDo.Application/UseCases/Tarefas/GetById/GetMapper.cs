using AutoMapper;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.GetById
{
    public sealed class GetMapper : Profile
    {
        public GetMapper()
        {
            CreateMap<Tarefa, TarefaResponse>();
        }
    }
}
