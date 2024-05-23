using HealthCare.PatientRegistry.BusinessObjects.Aggregates;
using HealthCareProSystem.PatientRegistry.BusinessObjects.Interfaces.Common;

namespace HealthCareProSystem.PatientRegistry.BusinessObjects.Repositories;
public interface ICommandPatientRegistryRepository : IUnitOfWork
{
    Task AddPatientAsync(PatientRegistryAggregate patient);
}
