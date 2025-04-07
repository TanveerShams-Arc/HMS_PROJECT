using System.ComponentModel.DataAnnotations;
using HMS_API.Models.Persons;

namespace HMS_API.Models
{
    public class Patient
    {

        [Key]
        public int PatientId { get; set; }

        [Required]
        public DateOnly PatientDOB { get; set; }

        [Required]
        public string PatientBloodGroup { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string PatientAddress { get; set; } = string.Empty;


        [Required]
        public string? AppUserId { get; set; }
        public AppUser AppUser { get; set; } = null!;

        public List<Appointment> Appointments { get; set; } = [];

        public List<HMSTransactionPar> Transactions { get; set; } = [];

        public List<MedicalRecords> MedicalRecords { get; set; } = [];

    }
}
