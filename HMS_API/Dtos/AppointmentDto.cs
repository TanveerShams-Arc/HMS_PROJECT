using System.ComponentModel.DataAnnotations;

namespace HMS_API.Dtos
{

    public class CreateAppointmentDto
    {
        [Required]
        public int PatientId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public string Status { get; set; } = string.Empty;

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int ReceptionistId { get; set; }
    }



    public class AppointmentDto
    {
        public int EventId { get; set; }
        public string PatientFullname { get; set; } = null!;
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public string DoctorFullname { get; set; } = null!;
        public string ReceptionistFullname { get; set; } = null!;
        public string doctorSpecialization { get; set; } = null!;
    }

    public class UpdateAppointmentDto
    {
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } = string.Empty;
    }


}
