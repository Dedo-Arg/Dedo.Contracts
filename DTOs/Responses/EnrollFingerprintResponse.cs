using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record EnrollFingerprintResponse(
    Guid            EnrollmentId,
    OperationStatus Status,
    DateTime        EnrolledAt
);
