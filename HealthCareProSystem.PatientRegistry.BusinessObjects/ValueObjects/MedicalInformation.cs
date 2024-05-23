namespace HealthCare.PatientRegistry.BusinessObjects.ValueObjects;
public class MedicalInformation(string allergies,
    IEnumerable<Medicine> currentMedications,
    string preexistingConditions, string additionalComments)
{
    public string Allergies => allergies;
    public IEnumerable<Medicine> CurrentMedications => currentMedications = [];
    public string PreexistingConditions => preexistingConditions;
    public string AdditionalComments => additionalComments;
}
