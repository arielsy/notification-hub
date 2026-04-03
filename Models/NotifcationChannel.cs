namespace NotificationHub.Models
{
    public class NotificationChannel
    {
        public NotificationChannelType Type { get; set; }
        public required string From {get;set;}
        public required string To {get;set;}
    }
}