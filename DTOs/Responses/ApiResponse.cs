namespace Dedo.Contracts.DTOs.Responses;

public record ApiResponse<T>(
    bool    Success,
    T?      Data,
    string? ErrorCode    = null,
    string? ErrorMessage = null
)
{
    public static ApiResponse<T> Ok(T data)
        => new(true, data);

    public static ApiResponse<T> Fail(string code, string message)
        => new(false, default, code, message);
}
