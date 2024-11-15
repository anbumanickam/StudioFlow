namespace StudioFlow.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public required string EventName { get; set; }
        public required string CustomerName { get; set; }
        public required string MobileNumber { get; set; }
        public required string EventLocation { get; set; }
        public string VideoEditorName { get; set; } = string.Empty;
        public string AlbumPrinterName { get; set; } = string.Empty;

        // Financial information related to the event
        public decimal TotalExpenses { get; set; }
        public decimal EventIncome { get; set; }
        public decimal EventProfit { get; set; }

        // Navigation property for Event's Status
        public required ICollection<EventStatus> EventStatuses { get; set; }

        // Navigation property for Event's Vendors
        public ICollection<Vendor>? Vendors { get; set; } 
    }
}
