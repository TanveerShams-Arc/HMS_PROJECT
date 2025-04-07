using HMS_API.Dtos;

namespace HMS_UI.Interfaces
{
    public interface IDoctorServices
    {
        Task<List<DoctorDto>> GetDoctorAsync(string doctorName, int doctorPageNumber, int doctorPageSize,
            int? doctorExperience, string? doctorSpecialization);

        Task<bool> DeleteDoctorAsync(int DoctorId);
    }
}
