using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Models;

namespace HMS_API.Interfaces
{
    public interface IReceptionistRepository
    {
        Task<List<Receptionist>> GetAllAsync(ReceptionistQueryObject query);
        Task<Receptionist?> GetByIdAsync(int id);
        Task<Receptionist> CreateAsync(Receptionist receptionistModel);
        Task<(Receptionist? updatedReceptionist, string newToken)> UpdateAsync(int id, UpdateReceptionistDto receptionistDto);
        Task<Receptionist?> DeleteAsync(int id);
        Task<bool> ReceptionistExistsAsync(int id);
    }
}
