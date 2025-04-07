using HMS_API.Dtos;
using HMS_API.Models;

namespace HMS_API.Interfaces
{
    public interface IInventoryRepository
    {
        Task<List<Inventory>> GetAllAsync();
        Task<Inventory?> GetByIdAsync(int id);
        Task<Inventory> CreateAsync(Inventory inventory);
        Task<Inventory?> UpdateAsync(int id, UpdateInventoryDto inventoryDto);
        Task<Inventory?> DeleteAsync(int id);
    }
}
