using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record TransactionRecord(
    Guid          TransactionId,
    Guid          UserId,
    Guid          PaymentId,
    PaymentStatus Status,
    decimal       Amount,
    string        Currency,
    string        MerchantId,
    DateTime      CreatedAt,
    DateTime?     CompletedAt
);
