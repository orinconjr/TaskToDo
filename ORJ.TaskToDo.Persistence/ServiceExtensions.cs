using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ORJ.TaskToDo.Domain.Interfaces;
using ORJ.TaskToDo.Persistence.Context;
using ORJ.TaskToDo.Persistence.Producer;
using ORJ.TaskToDo.Persistence.Repositories;

namespace ORJ.TaskToDo.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionsString = configuration.GetConnectionString("sqlServer");

            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionsString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITarefaRepository, TarefaRepository>();

            services.AddScoped<IRabitMQProducer, RabitMQProducer>();
        }
    }

}
