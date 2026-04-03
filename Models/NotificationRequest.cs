namespace NotificationHub.Models
{
    public class NotificationRequest
    {
        public required NotificationChannel Channel { get; set; }
        public required NotificationType Type { get; set; }
        public string? Title { get; set; } 
        public string? Body { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}