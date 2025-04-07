using System.ComponentModel;
using System.Data;
using HMS_API.Dtos;
using HMS_UI.Enums;
using HMS_UI.Interfaces;

namespace HMS_UI.Services
{
    class InventoryServices : IInventoryServices
    {
        private readonly IInventoryRepository _inventoryRepository;
        public InventoryServices(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }


        public async Task<bool> DeleteRecordAsync(int inventoryId)
        {
            if (inventoryId <= 0)
                throw new ArgumentException("Invalid Event ID.");

            return await _inventoryRepository.DeleteRecordAsync(inventoryId);
        }



        public async Task<bool> CreateInventoryAsync(string? medicineName, string? selectedManufacturer, int medQuantity, DateTime expiryDate)
        {
            if (string.IsNullOrEmpty(medicineName))
                throw new NoNullAllowedException("Medicine Name must be given");

            if (string.IsNullOrEmpty(selectedManufacturer))
                throw new NoNullAllowedException("Medicine Manufacturer must be given");

            if (medQuantity == 0)
                throw new InvalidOperationException("Quantity should be minimum 1");

            if (expiryDate < DateTime.Now)
                throw new InvalidOperationException("Cannot add expired medicines");

            return await _inventoryRepository.CreateInventoryAsync(medicineName, selectedManufacturer, medQuantity, expiryDate);
        }

        public async Task<List<InventoryDto>?> GetInventoryAsync(string? medicineName, int pageNumber, int pageSize, string? selectedManufacturer, DateTime? expiryDate)
        {
            if (pageNumber <= 0 || pageSize <= 0)
                throw new ArgumentException("Page number and page size must be greater than zero.");

            if (!string.IsNullOrEmpty(selectedManufacturer))
            {
                Manufacturer? selectedManufacturerObj = Enum.GetValues(typeof(Manufacturer))
                                                   .Cast<Manufacturer>()
                                                   .FirstOrDefault(m =>
                                                       ((DescriptionAttribute)Attribute.GetCustomAttribute(
                                                           m.GetType().GetField(m.ToString()),
                                                           typeof(DescriptionAttribute)))
                                                       ?.Description == selectedManufacturer);

                if (selectedManufacturerObj == null)
                {
                    throw new ArgumentException($"Invalid Manufacturer: {selectedManufacturer}");
                }
            }

            return await _inventoryRepository.GetInventoryAsync(medicineName, pageNumber, pageSize, selectedManufacturer, expiryDate);

        }
    }
}
