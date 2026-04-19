using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record NotificationRequestedEvent(
    Guid                       UserId,
    NotificationChannel        Channel,
    string                     TemplateId,
    IReadOnlyDictionary<string, string> Data
) : BaseEvent;
