using System.ComponentModel.DataAnnotations;

namespace HMS_API.Dtos
{

    public class CreateReceptionistDto
    {

        [Required]
        public string AppUserId { get; set; } = string.Empty;

    }


    public class ReceptionistDto : AppUserDto
    {
        public int ReceptionistId { get; set; }

    }


    public class UpdateReceptionistDto : AppUserDto
    {
    }

}
