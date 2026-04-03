namespace NotificationHub.Models
{
    public record NotificationChannel
    (
        NotificationChannelType Type,
        string From,
        string To
    );
}