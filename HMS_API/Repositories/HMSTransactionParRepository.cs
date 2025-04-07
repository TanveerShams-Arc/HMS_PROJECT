using HMS_API.DB;
using HMS_API.Dtos;
using HMS_API.Interfaces;
using HMS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HMS_API.Repositories
{
    public class HMSTransactionParRepository : IHMSTransactionParRepository
    {
        private readonly AppDBContext _context;

        public HMSTransactionParRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<HMSTransactionPar>> GetAllAsync()
        {
            return await _context.HMSTransactionPar.Include(t => t.Patient).ThenInclude(a => a.AppUser).ToListAsync();
        }

        public async Task<HMSTransactionPar?> GetByIdAsync(int id)
        {
            return await _context.HMSTransactionPar
                .Include(t => t.Patient).ThenInclude(a => a.AppUser)
                .FirstOrDefaultAsync(t => t.TransactionId == id);
        }

        public async Task<HMSTransactionPar> CreateAsync(HMSTransactionPar transaction)
        {
            await _context.HMSTransactionPar.AddAsync(transaction);
            await _context.SaveChangesAsync();

            return await _context.HMSTransactionPar
                            .Include(t => t.Patient).ThenInclude(a => a.AppUser)
                            .FirstOrDefaultAsync(t => t.TransactionId == transaction.TransactionId);
        }

        public async Task<HMSTransactionPar?> UpdateAsync(int id, UpdateHMSTransactionParDto transactionDto)
        {
            var existingTransaction = await _context.HMSTransactionPar.FirstOrDefaultAsync(t => t.TransactionId == id);
            if (existingTransaction == null) return null;

            existingTransaction.Amount = transactionDto.Amount;
            existingTransaction.PaidAmount = transactionDto.PaidAmount;
            existingTransaction.Status = transactionDto.Status;

            await _context.SaveChangesAsync();
            return await _context.HMSTransactionPar
                .Include(t => t.Patient).ThenInclude(a => a.AppUser)
                .FirstOrDefaultAsync(t => t.TransactionId == existingTransaction.TransactionId);
        }

        public async Task<HMSTransactionPar?> DeleteAsync(int id)
        {
            var transaction = await _context.HMSTransactionPar.FirstOrDefaultAsync(t => t.TransactionId == id);
            if (transaction == null) return null;

            _context.HMSTransactionPar.Remove(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }
    }
}
