using HealthCare.PatientRegistry.BusinessObjects.POCOEntities;
using HealthCare.PatientRegistry.BusinessObjects.ValueObjects;
using HealthCareProSystem.PatientRegistry.Entity.Backend.Dtos.PatientRegistry;

namespace HealthCare.PatientRegistry.BusinessObjects.Aggregates;
public class PatientRegistryAggregate : Patient
{
    private MedicalInformation _medicalInformation;
    public MedicalInformation MedicalInformation => _medicalInformation;
    /// <summary>
    /// Method that allows adding the patient's medical information, along with the medication currently administered.
    /// </summary>
    /// <param name="allergies">Known allergies </param>
    /// <param name="medications">List of medications currently available to the patient.</param>
    /// <param name="preexistingConditions">Pre-existing medical conditions.</param>
    /// <param name="additionalComments">Comments</param>
    public void AddMedicalInformation(string allergies, IEnumerable<Medicine> medications, string preexistingConditions, string additionalComments)
    {
        _medicalInformation = new MedicalInformation(allergies,
            medications,
            preexistingConditions,
            additionalComments);
    }
    private void AddMedicines(IEnumerable<MedicineRegistryDto> medications)
    {
        _medicalInformation. = medications;
    }
    /// <summary>
    /// Method to map data from the DTO to the POCO entity
    /// </summary>
    /// <param name="createPatientDto">DTO coming with patient data</param>
    /// <returns></returns>
    public static PatientRegistryAggregate From(PatientRegistryDto createPatientDto)
    {
        PatientRegistryAggregate patientAggregate = new PatientRegistryAggregate
        {
            FirstName = createPatientDto.FirstName,
            LastName = createPatientDto.LastName,
            DateOfBirth = createPatientDto.DateOfBirth,
            Gender = createPatientDto.Gender,
            Address = createPatientDto.Address,
            PhoneNumber = createPatientDto.PhoneNumber,
            Email = createPatientDto.Email,
            DocumentNumber = createPatientDto.DocumentNumber,
            HealthInsurance = createPatientDto.HealthInsurance,
            AdditionalComments = createPatientDto.AdditionalComments
        };

        if (createPatientDto.MedicalInformation != null)
        {
            List<Medicine> medicines = new List<Medicine>();

            if (createPatientDto.MedicalInformation.Medicines != null)
            {
                medicines = createPatientDto.MedicalInformation.Medicines
                .Select(medicine => new Medicine(medicine.Name, medicine.Dose, medicine.Frequency, medicine.AdditionalComments))
                .ToList();
            }
            patientAggregate.AddMedicalInformation(
                createPatientDto.MedicalInformation.Allergies,
                medicines,
                createPatientDto.MedicalInformation.PreexistingConditions,
                createPatientDto.MedicalInformation.AdditionalComments);
        }
        return patientAggregate;
    }
}
