namespace Dedo.Contracts.DTOs.Responses;

public record MpPaymentResponse(
    string   MpPaymentId,
    string   Status,
    decimal  Amount,
    DateTime CreatedAt
);
