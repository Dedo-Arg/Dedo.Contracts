namespace Dedo.Contracts.DTOs.Events;

public record PaymentBlockRequestEvent(
    Guid     PaymentId,
    Guid     UserId,
    Guid     FraudAlertId,
    string   Reason,
    DateTime RequestedAt
) : BaseEvent;
