namespace Dedo.Contracts.DTOs.Events;

public record UserSuspendRequestEvent(
    Guid     UserId,
    Guid     FraudAlertId,
    string   Reason,
    DateTime RequestedAt
) : BaseEvent;
