using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record BiometricMatchedEvent(
    Guid                 UserId,
    BiometricMatchResult Result,
    DateTime             MatchedAt,
    string               DeviceId
) : BaseEvent;
