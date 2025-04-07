using HMS_API.Dtos;
using HMS_API.Models;

namespace HMS_API.Interfaces
{
    public interface IPrescriptionRepository
    {
        Task<List<Prescription>> GetAllAsync();
        Task<Prescription?> GetByIdAsync(int id);
        Task<Prescription> CreateAsync(Prescription prescription);
        Task<Prescription?> UpdateAsync(int id, UpdatePrescriptionDto prescriptionDto);
        Task<Prescription?> DeleteAsync(int id);
    }
}
