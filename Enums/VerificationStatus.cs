namespace Dedo.Contracts.Enums;

// REGLA: NUNCA usar strings para estados. Solo Enums mapeados a PostgreSQL ENUM types.

/// <summary>PostgreSQL: verification_status</summary>
public enum VerificationStatus
{
    Pending   = 0,
    Verified  = 1,
    Expired   = 2,
    Rejected  = 3,
    Suspended = 4
}
