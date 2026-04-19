namespace Dedo.Contracts.DTOs.Requests;

public record CompleteEnrollmentRequest(
    string QrSessionToken,
    Guid   UserId,
    string FingerprintHash,
    string DeviceId
);
