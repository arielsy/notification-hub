using System.Text.Json;
using NotificationHub.Models;

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

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    Converters = { new System.Text.Json.Serialization.JsonStringEnumConverter() }
};

var notification = JsonSerializer.Deserialize<NotificationRequest>(json, options);

Console.WriteLine("Notificação recebida:");
Console.WriteLine($"  Canal: {notification!.Channel.Type}");
Console.WriteLine($"  De: {notification.Channel.From}");
Console.WriteLine($"  Para: {notification.Channel.To}");
Console.WriteLine($"  Tipo: {notification.Type}");
Console.WriteLine($"  Título: {notification.Title}");
Console.WriteLine($"  Mensagem: {notification.Body}");
Console.WriteLine($"  Criado em: {notification.CreatedAt}");