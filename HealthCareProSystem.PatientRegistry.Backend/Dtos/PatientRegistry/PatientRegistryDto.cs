using HealthCareProSystem.PatientRegistry.Entity.Backend.Enums;

namespace HealthCareProSystem.PatientRegistry.Entity.Backend.Dtos.PatientRegistry;
public class PatientRegistryDto(string firstName,
    string lastName, DateTime dateOfBirth, BiologicalSex sex, Gender gender,
    string address, string phoneNumber, string email,
    string documentNumber, string healthInsurance,
    string additionalComments, MedicalInformationRegistryDto medicalInformation)
{
    public string FirstName => firstName;
    public string LastName => lastName;
    public DateTime DateOfBirth => dateOfBirth;
    public BiologicalSex Sex => sex;
    public Gender Gender => gender;
    public string Address => address;
    public string PhoneNumber => phoneNumber;
    public string Email => email;
    public string DocumentNumber => documentNumber;
    public string HealthInsurance => healthInsurance;
    public string AdditionalComments => additionalComments;
    public MedicalInformationRegistryDto MedicalInformation => medicalInformation;
}
