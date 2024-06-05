using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Aggregates;
using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Interfaces.Common;

namespace HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Repositories;
public interface ICommandPatientRegistryRepository : IUnitOfWork
{
    Task AddPatientAsync(PatientRegistryAggregate patient);
}
