using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Aggregates;

namespace HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Interfaces.PatientRegistry;
public interface IPatientRegistryOutputPort
{
    double PatientId { get; }
    Task Handle(PatientRegistryAggregate patientRegistryDto);
}
