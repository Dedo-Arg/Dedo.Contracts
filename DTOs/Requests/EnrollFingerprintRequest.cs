namespace Dedo.Contracts.DTOs.Requests;

public record EnrollFingerprintRequest(
    Guid   UserId,
    string FingerprintHash,
    string DeviceId,
    string QrSessionId
);
