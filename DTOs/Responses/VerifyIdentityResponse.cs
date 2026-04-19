using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record VerifyIdentityResponse(
    Guid               VerificationId,
    VerificationStatus Status,
    DateTime           VerifiedAt,
    DateTime           ExpiresAt,
    string?            RejectionReason = null
);
