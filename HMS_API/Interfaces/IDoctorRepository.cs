using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Models;

namespace HMS_API.Interfaces
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> GetAllAsync(DoctorQueryObject query);
        Task<Doctor?> GetByIdAsync(int id);
        Task<Doctor> CreateAsync(Doctor doctorModel);
        Task<(Doctor? updatedDoctor, string newToken)> UpdateAsync(int id, UpdateDoctorDto doctorDto);
        Task<Doctor?> DeleteAsync(int id);
        Task<bool> DoctorExistsAsync(int id);
        //Task<int> GetNextUserIdAsync();

    }
}
