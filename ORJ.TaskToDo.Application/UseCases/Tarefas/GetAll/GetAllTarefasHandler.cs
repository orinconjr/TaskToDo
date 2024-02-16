using AutoMapper;
using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Interfaces;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.GetAll
{
    public sealed class GetHandler : IRequestHandler<GetAllTarefasRequest, List<TarefaResponse>>
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public GetHandler(ITarefaRepository tarefaRepository, IMapper mapper)
        {
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        public async Task<List<TarefaResponse>> Handle(GetAllTarefasRequest request, CancellationToken cancellationToken)
        {
            var tarefas = await _tarefaRepository.GetAll(cancellationToken);
            return _mapper.Map<List<TarefaResponse>>(tarefas);
        }
    }
}
