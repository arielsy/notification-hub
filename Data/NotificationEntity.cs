using System.ComponentModel;

namespace NotificationHub.Data;

public class NotificationEntity 
{
    public int Id { get; set; }
    public string ChannelType { get; set; } = string.Empty;
    public string ChannelFrom { get; set; } = string.Empty;
    public string ChannelTo { get; set; } = string.Empty;
    public string NotificationType { get; set; } = string.Empty;
    public string? Title { get; set; }
    public string? Body { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime SavedAt { get; set; }


}