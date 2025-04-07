namespace HMS_API.HelperFunctions.QueryObjects
{
    public class InventoryQueryObject : generalQueryObjects
    {
        public string? medicine { get; set; }
        public string? manufacturer { get; set; }
        public DateOnly? expiryDate { get; set; }
    }
}