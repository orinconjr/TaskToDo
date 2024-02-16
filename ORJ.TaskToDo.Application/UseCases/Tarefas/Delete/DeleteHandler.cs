using AutoMapper;
using MediatR;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Domain.Interfaces;

namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Delete
{
    public sealed class DeleteHandler :
                    IRequestHandler<DeleteRequest, TarefaResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public DeleteHandler(IUnitOfWork unitOfWork,
                                 ITarefaRepository tarefaRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        public async Task<TarefaResponse> Handle(DeleteRequest request,
                                                     CancellationToken cancellationToken)
        {

            var tarefa = await _tarefaRepository.Get(request.Id, cancellationToken);

            if (tarefa == null) return default;

            _tarefaRepository.Delete(tarefa);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<TarefaResponse>(tarefa);
        }
    }
}
