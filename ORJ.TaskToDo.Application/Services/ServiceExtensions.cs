using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ORJ.TaskToDo.Application.Shared.Behavior;
using System.Reflection;

namespace ORJ.TaskToDo.Application.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}
