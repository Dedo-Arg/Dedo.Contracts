namespace Dedo.Contracts.DTOs.Requests;

public record UpdatePaymentLimitsRequest(
    Guid    UserId,
    decimal MaxAmountPerTransaction,
    decimal MaxAmountPerDay
);
