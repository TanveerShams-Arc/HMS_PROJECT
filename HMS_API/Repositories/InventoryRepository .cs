using HMS_API.DB;
using HMS_API.Dtos;
using HMS_API.Interfaces;
using HMS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HMS_API.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly AppDBContext _context;

        public InventoryRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<Inventory>> GetAllAsync()
        {
            return await _context.Inventory.ToListAsync();
        }

        public async Task<Inventory?> GetByIdAsync(int id)
        {
            return await _context.Inventory.FirstOrDefaultAsync(i => i.ItemId == id);
        }

        public async Task<Inventory> CreateAsync(Inventory inventory)
        {
            await _context.Inventory.AddAsync(inventory);
            await _context.SaveChangesAsync();
            return inventory;
        }

        public async Task<Inventory?> UpdateAsync(int id, UpdateInventoryDto inventoryDto)
        {
            var existingInventory = await _context.Inventory.FirstOrDefaultAsync(i => i.ItemId == id);
            if (existingInventory == null) return null;

            existingInventory.Medicine = inventoryDto.Medicine;
            existingInventory.MedicineQuantity = inventoryDto.MedicineQuantity;
            existingInventory.Manufacturer = inventoryDto.Manufacturer;
            existingInventory.ExpiryDate = inventoryDto.ExpiryDate;
            existingInventory.LastUpdatedOn = DateTime.Now;

            await _context.SaveChangesAsync();
            return existingInventory;
        }

        public async Task<Inventory?> DeleteAsync(int id)
        {
            var inventory = await _context.Inventory.FirstOrDefaultAsync(i => i.ItemId == id);
            if (inventory == null) return null;

            _context.Inventory.Remove(inventory);
            await _context.SaveChangesAsync();
            return inventory;
        }
    }
}
