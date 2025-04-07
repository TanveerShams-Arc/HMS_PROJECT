namespace HMS_UI.HelperFunctions
{
    public class AppointmentQueryObject
    {

        public string PageNumber { get; set; } = "1";
        public string PageSize { get; set; } = "100";
        public string? Status { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string? DoctorName { get; set; }
        public string? PatientName { get; set; }
        public string? ReceptionistName { get; set; }

    }
}
