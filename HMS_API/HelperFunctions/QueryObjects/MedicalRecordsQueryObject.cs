namespace HMS_API.HelperFunctions.QueryObjects
{
    public class MedicalRecordsQueryObject : generalQueryObjects
    {
        public string? RecordType { get; set; }
        public string? PatientName { get; set; }
    }
}
