using Microsoft.AspNetCore.Identity;

namespace HMS_API.Models.Persons
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; } = "";


        public Doctor? Doctor { get; set; }
        public Patient? Patient { get; set; }

        public Receptionist? Receptionist { get; set; }
    }
}
