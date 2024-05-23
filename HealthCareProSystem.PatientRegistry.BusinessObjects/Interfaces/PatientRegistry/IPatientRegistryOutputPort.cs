using HealthCare.PatientRegistry.BusinessObjects.Aggregates;

namespace HealthCareProSystem.PatientRegistry.BusinessObjects.Interfaces.PatientRegistry;
public interface IPatientRegistryOutputPort
{
    double PatientId { get; }
    Task Handle(PatientRegistryAggregate patientRegistryDto);
}
