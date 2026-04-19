namespace Dedo.Contracts.DTOs.Events;

public record IdentityVerificationFailedEvent(
    Guid   UserId,
    string Reason
) : BaseEvent;
