using System.ComponentModel.DataAnnotations;

namespace HMS_API.Dtos
{


    public class CreateDoctorDto : AppUserDto
    {

        public string DoctorSpecialization { get; set; } = "";
        public int DoctorExperience { get; set; }

        [Required]
        public string AppUserId { get; set; } = string.Empty;

    }


    public class DoctorDto : AppUserDto
    {
        public int DoctorId { get; set; }
        public string DoctorSpecialization { get; set; } = string.Empty;
        public int DoctorExperience { get; set; }

    }

    public class UpdateDoctorDto : AppUserDto
    {
        public string DoctorSpecialization { get; set; } = "";
        public int DoctorExperience { get; set; }
    }


}


