using System.Data;
using HMS_API.Dtos;
using HMS_UI.Enums;
using HMS_UI.Interfaces;

namespace HMS_UI.Services
{
    class RecordServices : IRecordServices
    {
        private readonly IRecordRepository _recordRepository;
        public RecordServices(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public async Task<bool> CreateRecordAsync(string patientID, string recordType, string recordData, DateTime recordCreatedOn)
        {
            if (string.IsNullOrEmpty(patientID))
                throw new NoNullAllowedException("Patient must be selected");


            int patientId = int.Parse(patientID);

            if (string.IsNullOrEmpty(recordType))
                throw new InvalidOperationException("No Accepted Record Types were selected!");

            if (string.IsNullOrEmpty(recordData))
                throw new InvalidOperationException("Record Data Needed!");

            return await _recordRepository.CreateRecordAsync(patientId, recordType, recordData, recordCreatedOn);
        }

        public async Task<bool> DeleteRecordAsync(int recordId)
        {
            if (recordId <= 0)
                throw new ArgumentException("Invalid Event ID.");

            return await _recordRepository.DeleteRecordAsync(recordId);
        }

        public async Task<List<MedicalRecordsDto>> GetRecordsAsync(string? patientName, int pageNumber, int pageSize, string? recordType, DateTime? recordCreatedOn)
        {
            if (pageNumber <= 0 || pageSize <= 0)
                throw new ArgumentException("Page number and page size must be greater than zero.");

            if (!string.IsNullOrEmpty(recordType) && !Enum.IsDefined(typeof(MedicalRecordType),
                recordType))
            {
                throw new ArgumentException($"Invalid Record Type: {recordType}");
            }

            return await _recordRepository.GetRecordsAsync(patientName, pageNumber, pageSize, recordType, recordCreatedOn);

        }
    }
}
