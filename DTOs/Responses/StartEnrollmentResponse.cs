namespace Dedo.Contracts.DTOs.Responses;

public record StartEnrollmentResponse(
    string   QrSessionToken,
    string   QrImageBase64,
    DateTime ExpiresAt
);
