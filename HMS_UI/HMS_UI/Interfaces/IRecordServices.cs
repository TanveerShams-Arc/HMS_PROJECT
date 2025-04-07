using HMS_API.Dtos;

namespace HMS_UI.Interfaces
{
    public interface IRecordServices
    {
        Task<List<MedicalRecordsDto>> GetRecordsAsync(string? patientName, int pageNumber, int pageSize, string recordType,
                DateTime? recordCreatedOn);

        Task<bool> DeleteRecordAsync(int recordId);

        Task<bool> CreateRecordAsync(string patientId, string recordType, string recordData, DateTime recordCreatedOn);
    }
}
