using HMS_API.Dtos;

namespace HMS_UI.Interfaces
{
    interface IDoctorRepository
    {
        Task<bool> DeleteDoctorAsync(int doctorId);
        Task<List<DoctorDto>> GetDoctorAsync(string doctorName, int doctorPageNumber, int doctorPageSize,
            int? doctorExperience, string? doctorSpecialization);
    }
}
