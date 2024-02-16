using AutoMapper;
using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Interfaces;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Update
{
    public class UpdateHandler : IRequestHandler<UpdateRequest, TarefaResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public UpdateHandler(IUnitOfWork unitOfWork,
                                 ITarefaRepository tarefaRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }
        public async Task<TarefaResponse> Handle(UpdateRequest command,
                                                     CancellationToken cancellationToken)
        {
            var tarefa = await _tarefaRepository.Get(command.Id, cancellationToken);

            if (tarefa is null) return default;


            tarefa.Description = command.Description;
            tarefa.Active = command.Active;

            _tarefaRepository.Update(tarefa);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<TarefaResponse>(tarefa);
        }
    }
}