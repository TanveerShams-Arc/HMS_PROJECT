using System.ComponentModel.DataAnnotations;

namespace HMS_API.Models
{
    public class Inventory
    {
        [Key]
        public int ItemId { get; set; }

        [Required, MaxLength(100)]
        public string Medicine { get; set; } = string.Empty;

        [Required, Range(0, 10000)]
        public int MedicineQuantity { get; set; }

        [Required, MaxLength(100)]
        public string Manufacturer { get; set; } = string.Empty;

        [Required]
        public DateTime ExpiryDate { get; set; }

        [Required]
        public DateTime LastUpdatedOn { get; set; } = DateTime.Now;

    }
}
