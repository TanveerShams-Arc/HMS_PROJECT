using System.ComponentModel.DataAnnotations;

namespace HMS_API.Dtos
{

    public class CreateHMSTransactionParDto
    {
        [Required]
        public int PatientId { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public decimal Amount { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Paid Amount must be greater than zero.")]
        public decimal PaidAmount { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = string.Empty;
    }


    public class HMSTransactionParDto
    {
        public int TransactionId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = "";
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; } = "";

    }

    public class UpdateHMSTransactionParDto
    {
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
