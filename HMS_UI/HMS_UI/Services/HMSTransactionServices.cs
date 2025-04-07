using System.Data;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_UI.Enums;
using HMS_UI.Interfaces;

namespace HMS_UI.Services
{
    class HMSTransactionServices(IHMSTransactionRepository transactionRepository) : IHMSTransactionServices
    {
        private readonly IHMSTransactionRepository _transactionRepository = transactionRepository;

        public async Task<bool> CreateTransactionAsync(string? patientId, decimal amount, decimal paidAmount, string status, DateTime transactionDate)
        {
            if (string.IsNullOrEmpty(patientId))
                throw new NoNullAllowedException("Patient ID cannot be null!");

            if (amount < 0 || paidAmount < 0)
                throw new ArgumentException("Amount and Paid Amount must be non-negative!");

            if (paidAmount > amount)
                throw new ArgumentException("Paid Amount cannot be greater than Total Amount!");

            if (!Enum.TryParse(typeof(TransactionStatus), status, out _))
                throw new ArgumentException("Invalid transaction status.");

            int pID = int.Parse(patientId);

            try
            {
                var transactionDto = new CreateHMSTransactionParDto
                {
                    PatientId = pID,
                    Amount = amount,
                    PaidAmount = paidAmount,
                    TransactionDate = transactionDate,
                    Status = status,
                };

                return await _transactionRepository.CreateTransactionAsync(transactionDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async Task<bool> DeleteTransactionAsync(int transactionId)
        {
            if (transactionId <= 0)
                throw new ArgumentException("Invalid Transaction ID.");

            return await _transactionRepository.DeleteTransactionAsync(transactionId);
        }

        public async Task<List<HMSTransactionParDto>?> GetTransactionsAsync(TransactionQueryObject queryObject)
        {
            ArgumentNullException.ThrowIfNull(queryObject);

            if (!string.IsNullOrWhiteSpace(queryObject.Status) && !Enum.TryParse(typeof(TransactionStatus), queryObject.Status, out _))
                throw new ArgumentException("Invalid transaction status.");

            return await _transactionRepository.GetTransactionsAsync(queryObject);
        }

        public async Task<bool> UpdateTransactionAsync(int id, decimal amount, decimal paidAmount, string status)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Transaction ID.");

            if (amount < 0 || paidAmount < 0)
                throw new ArgumentException("Amount and Paid Amount must be non-negative!");

            if (paidAmount > amount)
                throw new ArgumentException("Paid Amount cannot be greater than Total Amount!");

            if (!string.IsNullOrEmpty(status) && !Enum.TryParse(typeof(TransactionStatus), status, out _))
                throw new ArgumentException("Invalid transaction status.");

            return await _transactionRepository.UpdateTransactionAsync(id, amount, paidAmount, status);
        }
    }
}
