using Microsoft.EntityFrameworkCore;
using ORJ.TaskToDo.Domain.Entities;

namespace ORJ.TaskToDo.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
