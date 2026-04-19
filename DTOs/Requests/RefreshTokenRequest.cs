namespace Dedo.Contracts.DTOs.Requests;

public record RefreshTokenRequest(
    string RefreshToken,
    string DeviceId
);
