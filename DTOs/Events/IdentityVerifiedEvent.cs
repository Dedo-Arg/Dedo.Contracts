using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record IdentityVerifiedEvent(
    Guid               VerificationId,
    Guid               UserId,
    VerificationStatus Status,
    DateTime           VerifiedAt
) : BaseEvent;
