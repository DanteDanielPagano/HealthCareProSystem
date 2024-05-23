using HealthCareProSystem.PatientRegistry.Entity.Backend.Dtos.PatientRegistry;

namespace HealthCareProSystem.PatientRegistry.BusinessObjects.Interfaces.PatientRegistry;
public interface IPatientRegistryInputPort
{
    Task Handle(PatientRegistryDto patientRegistryDto);
}
