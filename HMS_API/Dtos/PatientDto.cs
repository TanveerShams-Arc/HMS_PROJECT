using System.ComponentModel.DataAnnotations;

namespace HMS_API.Dtos
{

    public class CreatePatientDto
    {
        public DateOnly PatientDOB { get; set; }
        public string PatientBloodGroup { get; set; } = string.Empty;
        public string PatientAddress { get; set; } = string.Empty;

        [Required]
        public string AppUserId { get; set; } = string.Empty;
    }


    public class PatientDto : AppUserDto
    {
        public int PatientId { get; set; }
        public DateOnly PatientDOB { get; set; }
        public string PatientBloodGroup { get; set; } = string.Empty;
        public string PatientAddress { get; set; } = string.Empty;

    }

    public class UpdatePatientDto : AppUserDto
    {
        public DateOnly PatientDOB { get; set; }
        public string PatientBloodGroup { get; set; } = string.Empty;
        public string PatientAddress { get; set; } = string.Empty;
    }

}
