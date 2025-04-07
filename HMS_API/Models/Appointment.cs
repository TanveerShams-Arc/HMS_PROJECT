using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS_API.Models
{
    public partial class Appointment
    {

        [Key]
        public int EventId { get; set; }

        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; } = string.Empty;


        [Required, ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [Required, ForeignKey("Receptionist")]
        public int ReceptionistId { get; set; }

        public Doctor? Doctor { get; set; }
        public Patient? Patient { get; set; }
        public Receptionist? Receptionist { get; set; }
    }
}
