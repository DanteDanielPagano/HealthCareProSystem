namespace HealthCare.PatientRegistry.BusinessObjects.ValueObjects;

public class Medicine(string name, string dose, string frequency,
    string additionalComments)
{
    public string Name => name;
    public string Dose => dose;
    public string Frequency => frequency;
    public string AdditionalComments => additionalComments;
}