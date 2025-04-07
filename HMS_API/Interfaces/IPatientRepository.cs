using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Models;

namespace HMS_API.Interfaces
{
    public interface IPatientRepository
    {
        Task<List<Patient>> GetAllAsync(PatientQueryObject query);
        Task<Patient?> GetByIdAsync(int id);
        Task<Patient> CreateAsync(Patient patientModel);
        Task<(Patient? updatedPatient, string newToken)> UpdateAsync(int id, UpdatePatientDto patientDto);
        Task<Patient?> DeleteAsync(int id);
        Task<bool> PatientExistsAsync(int id);
    }
}
