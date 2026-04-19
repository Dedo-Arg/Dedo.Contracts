namespace Dedo.Contracts.DTOs.Events;

public record BiometricEnrolledEvent(
    Guid     UserId,
    DateTime EnrolledAt
) : BaseEvent;
