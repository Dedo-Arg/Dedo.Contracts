using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record TransactionSummaryResponse(
    Guid          TransactionId,
    PaymentStatus Status,
    decimal       Amount,
    string        MerchantId,
    DateTime      CreatedAt
);
