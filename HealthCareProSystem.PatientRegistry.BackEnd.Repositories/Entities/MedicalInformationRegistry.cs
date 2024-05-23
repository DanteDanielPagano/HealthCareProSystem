using HealthCare.PatientRegistry.BusinessObjects.Commons;
using HealthCare.PatientRegistry.BusinessObjects.POCOEntities;

namespace HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Entities;
public class MedicalInformationRegistry : BaseEntity
{
    public Guid PatientId { get; set; }
    public Patient Patient { get; set; }
    public string Allergies { get; set; }
    public IEnumerable<MedicineRegistry> CurrentMedications { get; set; }
    public string PreexistingConditions { get; set; }
    public string AdditionalComments { get; set; }
}
