using HealthCareProSystem.PatientRegistry.BusinessObjects.Interfaces.PatientRegistry;
using HealthCareProSystem.PatientRegistry.BusinessObjects.UseCases;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddUseCasesServices(
        this IServiceCollection services)
    {
        services.AddScoped<IPatientRegistryInputPort, RegisterPatientIteractor>();

        return services;
    }
}
