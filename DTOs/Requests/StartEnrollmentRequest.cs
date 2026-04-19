namespace Dedo.Contracts.DTOs.Requests;

public record StartEnrollmentRequest(
    string  PosId,
    string  MerchantId,
    decimal Amount
);
