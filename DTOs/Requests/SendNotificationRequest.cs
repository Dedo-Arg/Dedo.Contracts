using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Requests;

public record SendNotificationRequest(
    Guid                       UserId,
    NotificationChannel        Channel,
    string                     TemplateId,
    Dictionary<string, string> Data
);
