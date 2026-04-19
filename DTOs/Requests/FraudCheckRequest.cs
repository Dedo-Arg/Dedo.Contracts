namespace Dedo.Contracts.DTOs.Requests;

public record FraudCheckRequest(
    Guid     UserId,
    Guid     PaymentId,
    decimal  Amount,
    string   Currency,
    string   MerchantId,
    string   DeviceId,
    double?  Latitude,
    double?  Longitude,
    DateTime Timestamp
);
