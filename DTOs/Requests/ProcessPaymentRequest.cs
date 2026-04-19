namespace Dedo.Contracts.DTOs.Requests;

public record ProcessPaymentRequest(
    Guid    UserId,
    decimal Amount,
    string  Currency,
    string  MerchantId,
    string  PosId,
    string  DeviceId,
    double? Latitude,
    double? Longitude,
    string? Description = null
);
