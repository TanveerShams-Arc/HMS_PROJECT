namespace HMS_API.HelperFunctions.QueryObjects
{
    public class PrescriptionQueryObject : generalQueryObjects
    {
        public DateOnly? prescribedDate { get; set; }

        public string? DoctorName { get; set; }

        public string? PatientName { get; set; }

    }
}
