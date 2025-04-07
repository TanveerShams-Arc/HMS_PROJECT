using System.ComponentModel.DataAnnotations;

namespace HMS_API.Dtos
{

    public class CreateMedicalRecordsDto
    {
        [Required]
        public int PatientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string RecordType { get; set; } = string.Empty;

        [Required]
        public string RecordData { get; set; } = string.Empty;

        [Required]
        public DateTime RecordCreatedOn { get; set; }
    }

    public class MedicalRecordsDto
    {
        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = "";
        public string RecordType { get; set; } = "";
        public string RecordData { get; set; } = "";
        public DateTime RecordCreatedOn { get; set; }
    }

    public class UpdateMedicalRecordsDto
    {
        [MaxLength(100)]
        public string RecordType { get; set; } = string.Empty;

        public string RecordData { get; set; } = string.Empty;
    }
}

