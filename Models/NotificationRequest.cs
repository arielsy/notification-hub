namespace NotificationHub.Models
{
    public record NotificationRequest
    (
        NotificationChannel Channel,
        NotificationType Type,
        string? Title,
        string? Body,
        DateTime CreatedAt
    );
}