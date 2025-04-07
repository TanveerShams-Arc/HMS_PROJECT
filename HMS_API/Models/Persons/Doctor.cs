using System.ComponentModel.DataAnnotations;
using HMS_API.Models.Persons;

namespace HMS_API.Models
{
    public class Doctor
    {

        [Key]
        public int DoctorId { get; set; }

        [Required, MaxLength(100)]
        public string DoctorSpecialization { get; set; } = string.Empty;

        [Required, Range(0, 50)]
        public int DoctorExperience { get; set; }



        [Required]
        public string? AppUserId { get; set; }
        public AppUser AppUser { get; set; } = null!;
        public List<Appointment> Appointments { get; set; } = [];

    }
}
