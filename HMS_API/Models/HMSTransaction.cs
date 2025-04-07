using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS_API.Models
{
    public class HMSTransactionPar
    {
        [Key]
        public int TransactionId { get; set; }


        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }


        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal PaidAmount { get; set; }


        [Required]
        public DateTime TransactionDate { get; set; } = DateTime.Now;


        [Required, MaxLength(50)]
        public string Status { get; set; } = string.Empty;


        public Patient? Patient { get; set; }
    }
}
