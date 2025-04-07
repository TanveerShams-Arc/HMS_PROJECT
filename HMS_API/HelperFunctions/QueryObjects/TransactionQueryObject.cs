namespace HMS_API.HelperFunctions.QueryObjects
{
    public class TransactionQueryObject : generalQueryObjects
    {
        public DateTime? TransactionDate { get; set; }

        public string? PatientName { get; set; }

        public decimal? Amount { get; set; }

        public decimal? PaidAmount { get; set; }

        public string? Status { get; set; }
    }
}
