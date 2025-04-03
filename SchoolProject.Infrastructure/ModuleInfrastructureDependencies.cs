using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Repositories.Abstract;
using SchoolProject.Infrastructure.Repositories.Implementation;

namespace SchoolProject.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
          public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection service)
        {
            service.AddTransient<IStudentRepository,StudentRepository>();
            return service;
        }

    }
}
