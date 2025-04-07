using HMS_API.Dtos;

namespace HMS_UI.Interfaces
{
    public interface IInventoryRepository
    {
        Task<List<InventoryDto>?> GetInventoryAsync(string? medicineName, int pageNumber, int pageSize,
            string? selectedManufacturer, DateTime? expiryDate);

        Task<bool> CreateInventoryAsync(string? medicineName, string? selectedManufacturer, int medQuantity,
            DateTime expiryDate);

        Task<bool> DeleteRecordAsync(int inventoryId);
    }
}

