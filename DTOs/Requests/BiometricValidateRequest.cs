namespace Dedo.Contracts.DTOs.Requests;

public record BiometricValidateRequest(
    Guid    UserId,
    string  FingerprintHash,  // SHA-256 generado en el sensor del dispositivo
    string  DeviceId,
    double? Latitude,
    double? Longitude
);
