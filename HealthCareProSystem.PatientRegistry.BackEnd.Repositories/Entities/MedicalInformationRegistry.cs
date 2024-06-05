using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.Commons;
using HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.POCOEntities;

namespace HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Entities;
public class MedicalInformationRegistry : BaseEntity
{
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
    public string Allergies { get; set; }
    public IEnumerable<MedicineRegistry> CurrentMedications { get; set; }
    public string PreexistingConditions { get; set; }
    public string AdditionalComments { get; set; }
}
