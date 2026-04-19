namespace Dedo.Contracts.Enums;

/// <summary>PostgreSQL: token_status</summary>
public enum TokenStatus
{
    Active       = 0,
    ExpiringSoon = 1,
    Expired      = 2,
    Revoked      = 3
}
