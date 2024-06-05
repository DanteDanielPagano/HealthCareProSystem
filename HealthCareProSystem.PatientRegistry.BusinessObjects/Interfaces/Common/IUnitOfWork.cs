namespace HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Interfaces.Common;
public interface IUnitOfWork
{
    Task SaveChanges();
}
