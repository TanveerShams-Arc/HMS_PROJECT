using System.ComponentModel.DataAnnotations;

namespace HMS_API.Dtos
{

    public class CreateInventoryDto
    {
        [Required]
        public string Medicine { get; set; } = string.Empty;

        [Required, Range(0, 10000)]
        public int MedicineQuantity { get; set; }

        [Required]
        public string Manufacturer { get; set; } = string.Empty;

        [Required]
        public DateTime ExpiryDate { get; set; }
    }



    public class InventoryDto
    {
        public int ItemId { get; set; }
        public string Medicine { get; set; } = "";
        public int MedicineQuantity { get; set; }
        public string Manufacturer { get; set; } = "";
        public DateTime ExpiryDate { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }


    public class UpdateInventoryDto
    {
        public string Medicine { get; set; } = string.Empty;
        public int MedicineQuantity { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
        public DateTime ExpiryDate { get; set; }
    }

}
