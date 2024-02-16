using AutoMapper;
using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Entities;
using ORJ.TaskToDo.Domain.Interfaces;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Create
{
    public class CreateTarefaHandler : IRequestHandler<CreateTarefaRequest, TarefaResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public CreateTarefaHandler(IUnitOfWork unitOfWork, ITarefaRepository tarefaRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        public async Task<TarefaResponse> Handle(CreateTarefaRequest request, CancellationToken cancellationToken)
        {
            var tarefa = _mapper.Map<Tarefa>(request);
            _tarefaRepository.Create(tarefa);
            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<TarefaResponse>(tarefa);
        }

        
    }
}
