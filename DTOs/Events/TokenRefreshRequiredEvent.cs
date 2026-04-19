using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record TokenRefreshRequiredEvent(
    Guid     UserId,
    DateTime TokenExpiresAt
) : BaseEvent;
