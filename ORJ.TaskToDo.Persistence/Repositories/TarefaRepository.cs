using Microsoft.EntityFrameworkCore;
using ORJ.TaskToDo.Domain.Entities;
using ORJ.TaskToDo.Domain.Interfaces;
using ORJ.TaskToDo.Persistence.Context;

namespace ORJ.TaskToDo.Persistence.Repositories
{
    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(AppDbContext context) : base(context)
        { }

        public async Task<Tarefa> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Tarefas.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}
