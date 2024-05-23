namespace HealthCareProSystem.PatientRegistry.Entity.Backend.Dtos.PatientRegistry;
public class MedicineRegistryDto(string name, string dose, string frequency,
    string additionalComments)
{
    public string Name => name;
    public string Dose => dose;
    public string Frequency => frequency;
    public string AdditionalComments => additionalComments;
}
