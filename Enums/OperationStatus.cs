namespace Dedo.Contracts.Enums;

/// <summary>PostgreSQL: operation_status</summary>
public enum OperationStatus
{
    Success      = 0,
    Failed       = 1,
    PendingRetry = 2,
    Cancelled    = 3
}
