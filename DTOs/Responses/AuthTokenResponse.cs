namespace Dedo.Contracts.DTOs.Responses;

public record AuthTokenResponse(
    string   AccessToken,
    string   RefreshToken,
    DateTime ExpiresAt
);
