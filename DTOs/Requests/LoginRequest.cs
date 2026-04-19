namespace Dedo.Contracts.DTOs.Requests;

public record LoginRequest(
    string DniNumber,
    string FingerprintHash,
    string DeviceId
);
