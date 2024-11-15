namespace StudioFlow.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string? VendorName { get; set; }
        public decimal AmountSpent { get; set; }

        // Foreign key to link to an event
        public int EventId { get; set; }
        public required Event Event { get; set; }
    }
}
