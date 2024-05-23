using HealthCare.PatientRegistry.BusinessObjects.Aggregates;
using HealthCareProSystem.PatientRegistry.BusinessObjects.Interfaces.PatientRegistry;
using HealthCareProSystem.PatientRegistry.BusinessObjects.Repositories;
using HealthCareProSystem.PatientRegistry.Entity.Backend.Dtos.PatientRegistry;

namespace HealthCareProSystem.PatientRegistry.BusinessObjects.UseCases;
public class RegisterPatientIteractor(
    IPatientRegistryOutputPort outputPort,
    ICommandPatientRegistryRepository repository) : IPatientRegistryInputPort
{
    public async Task Handle(PatientRegistryDto patientRegistryDto)
    {
        PatientRegistryAggregate patient = PatientRegistryAggregate.From(patientRegistryDto);

        await repository.AddPatientAsync(patient);
        await repository.SaveChanges();
        await outputPort.Handle(patient);
    }
}
