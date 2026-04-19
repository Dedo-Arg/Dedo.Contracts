using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record TokenRefreshedEvent(
    Guid        UserId,
    TokenStatus NewStatus,
    DateTime    RefreshedAt,
    DateTime    NewExpiresAt
) : BaseEvent;
