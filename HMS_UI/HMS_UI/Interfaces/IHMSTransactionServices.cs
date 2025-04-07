using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;

namespace HMS_UI.Interfaces
{
    public interface IHMSTransactionServices
    {

        Task<bool> CreateTransactionAsync(string? patientId, decimal amount, decimal paidAmount, string status, DateTime transactionDate);

        Task<List<HMSTransactionParDto>?> GetTransactionsAsync(TransactionQueryObject query);

        Task<bool> UpdateTransactionAsync(int id, decimal amount, decimal paidAmount, string status);

        Task<bool> DeleteTransactionAsync(int transactionId);
    }
}
