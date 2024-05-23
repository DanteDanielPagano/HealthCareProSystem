using HealthCare.PatientRegistry.BusinessObjects.Aggregates;
using HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Interfaces;
using HealthCareProSystem.PatientRegistry.BusinessObjects.Repositories;

namespace HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Repository;
internal class CommandsRepository(
    ICommandPatientRegistryCommandDataContext context) : ICommandPatientRegistryRepository
{
    public async Task AddPatientAsync(PatientRegistryAggregate patient)
    {
        await context.AddPatientAsync(patient);
        await context.AddMedicalInformationAsync(
            patient.MedicalInformation);
    }

    public Task SaveChanges()
    {
        throw new NotImplementedException();
    }
}
