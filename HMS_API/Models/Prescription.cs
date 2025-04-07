using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS_API.Models
{
    public class Prescription
    {

        [Key]
        public int PrescriptionId { get; set; }

        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }

        [Required, ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [Required]
        public string MedicineDetails { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        [Required]
        public DateTime PrescribedOn { get; set; }

        public Patient? Patient { get; set; }
        public Doctor? Doctor { get; set; }


    }
}
