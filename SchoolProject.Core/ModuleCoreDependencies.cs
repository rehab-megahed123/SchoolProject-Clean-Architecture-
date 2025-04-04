using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolProject.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            //configuration of mediator
            services.AddMediatR(cfg =>
            
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())

            );
            //configuration of Auto Mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
