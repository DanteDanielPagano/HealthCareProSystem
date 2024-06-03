namespace HealthCareProSystem.PatientRegistry.BusinessObjects.Interfaces.Common;
public interface IUnitOfWork
{
    Task SaveChanges();
}
