using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record PaymentProcessedEvent(
    Guid          PaymentId,
    Guid          UserId,
    PaymentStatus Status,
    decimal       Amount,
    string        Currency,
    string        MerchantId,
    string        PosId,
    string        DeviceId,
    double?       Latitude,
    double?       Longitude,
    DateTime      ProcessedAt,
    int           ProcessingTimeMs,
    string?       MercadoPagoPaymentId = null
) : BaseEvent;
