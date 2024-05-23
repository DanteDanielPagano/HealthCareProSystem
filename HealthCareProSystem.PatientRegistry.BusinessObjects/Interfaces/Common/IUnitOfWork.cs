using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareProSystem.PatientRegistry.BusinessObjects.Interfaces.Common;
public interface IUnitOfWork
{
    Task SaveChanges();
}
