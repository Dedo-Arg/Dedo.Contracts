using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record BiometricValidateResponse(
    BiometricMatchResult Result,
    Guid                 UserId,
    double               ConfidenceScore,
    DateTime             ValidatedAt
);
