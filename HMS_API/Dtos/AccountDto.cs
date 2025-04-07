using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HMS_API.Dtos
{



    public class LoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }


    public class NewUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }


    public class EditUserDto
    {
        public string UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? FullName { get; set; }
    }


    public class RegisterDto
    {

        [Required]
        public string? Username { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; } = "";

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string Phone { get; set; } = "";

        [PasswordPropertyText]
        public string? Password { get; set; }

        [Required]
        public string Role { get; set; } = string.Empty;



        //Doctor
        public string? DoctorSpecialization { get; set; }
        public int? DoctorExperience { get; set; }



        //Patient
        public DateOnly? PatientDOB { get; set; }
        public string? PatientBloodGroup { get; set; }
        public string? PatientAddress { get; set; }
    }
}
