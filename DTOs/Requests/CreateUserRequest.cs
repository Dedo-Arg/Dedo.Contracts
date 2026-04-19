namespace Dedo.Contracts.DTOs.Requests;

public record CreateUserRequest(
    string DniNumber,
    string FullName,
    string PhoneNumber,
    Guid   VerificationId
);
