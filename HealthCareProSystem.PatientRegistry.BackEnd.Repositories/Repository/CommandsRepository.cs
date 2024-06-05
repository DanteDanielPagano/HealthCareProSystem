using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Aggregates;
using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Repositories;
using HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Entities;
using HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Interfaces;

namespace HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Repository;
internal class CommandsRepository(
    ICommandPatientRegistryCommandDataContext context) : ICommandPatientRegistryRepository
{
    public async Task AddPatientAsync(PatientRegistryAggregate patient)
    {
        await context.AddPatientAsync(patient);

        await context.AddMedicalInformationAsync(
            patient.MedicalInformation);

        await context.AddMedicineAsync(
            patient.MedicalInformation.CurrentMedications
            .Select(m => new MedicineRegistry
            {
                Name = m.Name,
                Dose = m.Dose,
                Frequency = m.Frequency,
                AdditionalComments = m.AdditionalComments
            }).ToArray());
    }

    public async Task SaveChanges()
    {
        await context.SaveChangeAsync();
    }
}
