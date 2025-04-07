using HMS_API.Dtos;
using HMS_API.Models;

namespace HMS_API.Interfaces
{
    public interface IMedicalRecordsRepository
    {
        Task<List<MedicalRecords>> GetAllAsync();
        Task<MedicalRecords?> GetByIdAsync(int id);
        Task<MedicalRecords> CreateAsync(MedicalRecords medicalRecord);
        Task<MedicalRecords?> UpdateAsync(int id, UpdateMedicalRecordsDto medicalRecordDto);
        Task<MedicalRecords?> DeleteAsync(int id);
    }
}
