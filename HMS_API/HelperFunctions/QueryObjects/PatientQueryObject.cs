namespace HMS_API.HelperFunctions.QueryObjects
{
    public class PatientQueryObject : generalQueryObjects
    {
        public DateOnly? PatientDOB { get; set; }

        public string? PatientBloodGroup { get; set; }

        public string? PatientAddress { get; set; }

        public string? PatientName { get; set; }

        public string? phoneNumber { get; set; }

    }
}