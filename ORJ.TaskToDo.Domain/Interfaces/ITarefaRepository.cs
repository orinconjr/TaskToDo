using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Domain.Interfaces
{
    public interface ITarefaRepository : IBaseRepository<Tarefa>
    {
        Task<Tarefa> GetById(Guid id, CancellationToken cancellationToken);
    }
}
