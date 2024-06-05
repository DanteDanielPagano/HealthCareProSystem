using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Repositories;
using HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Repository;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddRepositoriesServices(this IServiceCollection services)
    {
        services.AddScoped<ICommandPatientRegistryRepository, CommandsRepository>();

        return services;
    }
}
