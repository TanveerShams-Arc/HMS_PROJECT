namespace HMS_API.HelperFunctions.QueryObjects
{
    public class AppointmentQueryObject : generalQueryObjects
    {
        public DateOnly? AppointmentDate { get; set; }

        public string? DoctorName { get; set; }

        public string? PatientName { get; set; }

        public string? ReceptionistName { get; set; }

        public string? Status { get; set; }

    }
}
