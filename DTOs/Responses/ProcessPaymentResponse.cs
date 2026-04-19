using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record ProcessPaymentResponse(
    Guid          PaymentId,
    PaymentStatus Status,
    decimal       Amount,
    string        Currency,
    DateTime      ProcessedAt,
    int           ProcessingTimeMs,
    string?       MercadoPagoPaymentId = null
);
