namespace HealthCareProSystem.PatientRegistry.Entity.Backend.Dtos.PatientRegistry;

public class MedicalInformationRegistryDto(string allergies,
    IEnumerable<MedicineRegistryDto> medicines,
    string preexistingConditions, string additionalComments)
{
    public string Allergies => allergies;
    public IEnumerable<MedicineRegistryDto> Medicines => medicines;
    public string PreexistingConditions => preexistingConditions;
    public string AdditionalComments => additionalComments;
}