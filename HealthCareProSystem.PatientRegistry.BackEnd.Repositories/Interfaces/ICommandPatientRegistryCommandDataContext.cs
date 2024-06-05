using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.POCOEntities;
using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.ValueObjects;
using HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Entities;

namespace HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Interfaces;
public interface ICommandPatientRegistryCommandDataContext
{
    Task AddPatientAsync(Patient patient);
    Task AddMedicalInformationAsync(MedicalInformation medicalInformation);
    Task AddMedicineAsync(IEnumerable<MedicineRegistry> medicines);
    Task SaveChangeAsync();
}
