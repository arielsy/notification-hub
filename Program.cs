using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NotificationHub.Data;
using NotificationHub.Models;

var config = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
    .AddEnvironmentVariables()
    .Build();

var connectionString = config.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

var dbOptions = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlServer(connectionString)
    .Options;

using var db = new AppDbContext(dbOptions);
db.Database.EnsureCreated();

var json = """
{
    "Channel": {
        "Type": "Email",
        "From": "sistema@empresa.com",
        "To": "cliente@email.com"
    },
    "Type": "Text",
    "Title": "Bem-vindo",
    "Body": "Sua conta foi criada com sucesso!",
    "CreatedAt": "2026-04-04T10:00:00"
}
""";

var serializerOptions = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    Converters = { new System.Text.Json.Serialization.JsonStringEnumConverter() }
};

var notification = JsonSerializer.Deserialize<NotificationRequest>(json, serializerOptions)
    ?? throw new InvalidOperationException("Failed to deserialize notification.");

var entity = new NotificationEntity
{
    ChannelType = notification.Channel.Type.ToString(),
    ChannelFrom = notification.Channel.From,
    ChannelTo = notification.Channel.To,
    NotificationType = notification.Type.ToString(),
    Title = notification.Title,
    Body = notification.Body,
    CreatedAt = notification.CreatedAt,
    SavedAt = DateTime.UtcNow
};

db.Notifications.Add(entity);
db.SaveChanges();

Console.WriteLine("Notificação recebida e salva no banco:");
Console.WriteLine($"  ID: {entity.Id}");
Console.WriteLine($"  Canal: {notification!.Channel.Type}");
Console.WriteLine($"  De: {notification.Channel.From}");
Console.WriteLine($"  Para: {notification.Channel.To}");
Console.WriteLine($"  Tipo: {notification.Type}");
Console.WriteLine($"  Título: {notification.Title}");
Console.WriteLine($"  Mensagem: {notification.Body}");
Console.WriteLine($"  Criado em: {notification.CreatedAt}");