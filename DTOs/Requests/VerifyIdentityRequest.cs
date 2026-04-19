namespace Dedo.Contracts.DTOs.Requests;

public record VerifyIdentityRequest(
    string   DniNumber,
    string   FullName,
    DateTime BirthDate,
    byte[]   FaceImage   // Solo para validación RENAPER. NUNCA se almacena.
);
