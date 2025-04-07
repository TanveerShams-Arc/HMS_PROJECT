using HMS_API.Dtos;
using HMS_UI.Enums;
using HMS_UI.Interfaces;

namespace HMS_UI.Services
{
    class DoctorServices : IDoctorServices
    {

        private readonly IDoctorRepository _doctorRepository;
        public DoctorServices(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }


        public async Task<bool> DeleteDoctorAsync(int DoctorId)
        {

            if (DoctorId <= 0)
                throw new ArgumentException("Doctor ID must be greater than zero.");

            return await _doctorRepository.DeleteDoctorAsync(DoctorId);
        }

        public async Task<List<DoctorDto>> GetDoctorAsync(string doctorName, int doctorPageNumber, int doctorPageSize,
            int? doctorExperience, string? doctorSpecialization)
        {
            if (doctorPageNumber <= 0 || doctorPageSize <= 0)
                throw new ArgumentException("Page number and page size must be greater than zero.");

            if (!string.IsNullOrEmpty(doctorSpecialization) && !Enum.IsDefined(typeof(DoctorSpecialization),
                doctorSpecialization))
            {
                throw new ArgumentException($"Invalid doctor specialization: {doctorSpecialization}");
            }

            return await _doctorRepository.GetDoctorAsync(doctorName, doctorPageNumber, doctorPageSize, doctorExperience, doctorSpecialization);

        }
    }
}
