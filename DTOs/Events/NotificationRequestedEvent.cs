using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record NotificationRequestedEvent(
    Guid                       UserId,
    NotificationChannel        Channel,
    string                     TemplateId,
    Dictionary<string, string> Data
) : BaseEvent;
