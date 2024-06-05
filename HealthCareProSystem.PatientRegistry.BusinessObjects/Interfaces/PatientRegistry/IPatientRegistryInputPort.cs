using HealthCareProSystem.PatientRegistry.Entity.Dtos.PatientRegistry;

namespace HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Interfaces.PatientRegistry;
public interface IPatientRegistryInputPort
{
    Task Handle(PatientRegistryDto patientRegistryDto);
}
