using System.ComponentModel.DataAnnotations;
using HMS_API.Models.Persons;

namespace HMS_API.Models
{
    public class Receptionist
    {
        [Key]
        public int ReceptionistId { get; set; }




        [Required]
        public string? AppUserId { get; set; }
        public AppUser AppUser { get; set; } = null!;

        public List<Appointment> Appointments { get; set; } = [];
    }
}
