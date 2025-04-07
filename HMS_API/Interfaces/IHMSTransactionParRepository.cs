using HMS_API.Dtos;
using HMS_API.Models;

namespace HMS_API.Interfaces
{
    public interface IHMSTransactionParRepository
    {
        Task<List<HMSTransactionPar>> GetAllAsync();
        Task<HMSTransactionPar?> GetByIdAsync(int id);
        Task<HMSTransactionPar> CreateAsync(HMSTransactionPar transaction);
        Task<HMSTransactionPar?> UpdateAsync(int id, UpdateHMSTransactionParDto transactionDto);
        Task<HMSTransactionPar?> DeleteAsync(int id);
    }
}
