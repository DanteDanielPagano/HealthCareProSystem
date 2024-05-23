using HealthCare.PatientRegistry.BusinessObjects.Commons;

namespace HealthCareProSystem.PatientRegistry.BackEnd.Repositories.Entities;
public class MedicineRegistry : BaseEntity
{
    public Guid MedicalInformationId { get; set; }
    public MedicalInformationRegistry MedicalInformation { get; set; }
    public string Name { get; set; }
    public string Dose { get; set; }
    public string Frequency { get; set; }
    public string AdditionalComments { get; set; }
}
