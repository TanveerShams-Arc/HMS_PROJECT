using HMS_API.Dtos;

namespace HMS_UI.Interfaces
{
    public interface IPatientServices
    {
        Task<List<PatientDto>> GetPatientsAsync(string patientName, int patientPageNumber, int patientPageSize);
    }
}
