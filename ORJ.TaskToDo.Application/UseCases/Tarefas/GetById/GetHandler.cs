using AutoMapper;
using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Interfaces;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.GetById
{
    public sealed class GetHandler : IRequestHandler<GetRequest, TarefaResponse>
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public GetHandler(ITarefaRepository tarefaRepository, IMapper mapper)
        {
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        public async Task<TarefaResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var tarefa = await _tarefaRepository.GetById(request.Id, cancellationToken);
            return _mapper.Map<TarefaResponse>(tarefa);
        }
    }
}
