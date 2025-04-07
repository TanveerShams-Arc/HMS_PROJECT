using System.ComponentModel.DataAnnotations;

namespace HMS_API.Dtos
{

    public class CreatePrescriptionDto
    {
        [Required]
        public int PatientId { get; set; }
        [Required]
        public int DoctorId { get; set; }
        [Required]
        public string MedicineDetails { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        [Required]
        public DateTime PrescribedOn { get; set; }
    }


    public class PrescriptionDto
    {
        public int PrescriptionId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = null!;
        public int DoctorId { get; set; }
        public string DoctorName { get; set; } = null!;
        public string MedicineDetails { get; set; } = "";
        public string Notes { get; set; } = "";
        public DateTime PrescribedOn { get; set; }
    }

    public class UpdatePrescriptionDto
    {
        public string MedicineDetails { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime PrescribedOn { get; set; }
    }
}
