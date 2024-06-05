using HealthCareProSystem.PatientRegistry.Entity.Enums;

namespace HealthCareProSystem.PatientRegistry.Backend.BusinessObjects.POCOEntities;
public class Patient
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public BiologicalSex Sex { get; set; }
    public Gender Gender { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string DocumentNumber { get; set; }
    public string HealthInsurance { get; set; }
    public string AdditionalComments { get; set; }
}
