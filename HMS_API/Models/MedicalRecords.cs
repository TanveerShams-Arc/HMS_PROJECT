using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS_API.Models
{
    public class MedicalRecords
    {
        [Key]
        public int RecordId { get; set; }

        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }

        [Required, MaxLength(100)]
        public string RecordType { get; set; } = string.Empty;

        [Required]
        public string RecordData { get; set; } = string.Empty;

        [Required]
        public DateTime RecordCreatedOn { get; set; }

        public Patient? Patient { get; set; }

    }
}

