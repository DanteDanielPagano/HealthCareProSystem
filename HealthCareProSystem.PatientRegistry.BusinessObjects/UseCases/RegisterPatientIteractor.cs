using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Aggregates;
using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Interfaces.PatientRegistry;
using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Repositories;
using HealthCareProSystem.PatientRegistry.Entity.Dtos.PatientRegistry;

namespace HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.UseCases;
public class RegisterPatientIteractor : IPatientRegistryInputPort
{
    private readonly IPatientRegistryOutputPort _outputPort;
    private readonly ICommandPatientRegistryRepository _repository;
    public RegisterPatientIteractor(IPatientRegistryOutputPort outputPort, ICommandPatientRegistryRepository repository)
    {
        _outputPort = outputPort;
        _repository = repository;
    }

    public async Task Handle(PatientRegistryDto patientRegistryDto)
    {
        PatientRegistryAggregate patient = PatientRegistryAggregate.From(patientRegistryDto);

        await _repository.AddPatientAsync(patient);
        await _repository.SaveChanges();
        await _outputPort.Handle(patient);
    }
}


