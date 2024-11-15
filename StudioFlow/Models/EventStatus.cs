namespace StudioFlow.Models
{
    public class EventStatus
    {
        public int EventStatusId { get; set; }
        public required string Status { get; set; }  // e.g. Video Editing Progress, Wedding Shoot, etc.
        public int EventId { get; set; }

        // Navigation property for the Event this status belongs to
        public required Event Event { get; set; }
    }
}
