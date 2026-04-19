using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record UserResponse(
    Guid               UserId,
    string             DniNumber,
    string             FullName,
    string             PhoneNumber,
    VerificationStatus VerificationStatus,
    bool               IsBiometricEnrolled,
    decimal            MaxAmountPerTransaction,
    decimal            MaxAmountPerDay,
    DateTime           CreatedAt
);
