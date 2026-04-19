using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record CompleteEnrollmentResponse(
    bool          Success,
    Guid?         TransactionId,
    PaymentStatus PaymentStatus,
    DateTime      ProcessedAt
);
