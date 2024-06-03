using HealthCareProSystem.PatientRegistry.Entity.Backend.Enums;

namespace HealthCare.PatientRegistry.BusinessObjects.POCOEntities;
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
