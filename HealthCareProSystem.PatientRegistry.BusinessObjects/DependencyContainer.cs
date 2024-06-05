using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Interfaces.PatientRegistry;
using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace HealthCareProSystem.PatientRegistry.Backend.BusinessObjects;
public static class DependencyContainer
{
    public static IServiceCollection AddUseCasesServices(
        this IServiceCollection services)
    {
        services.AddScoped<IPatientRegistryInputPort, RegisterPatientIteractor>();

        return services;
    }
}
