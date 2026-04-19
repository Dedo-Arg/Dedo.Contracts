namespace Dedo.Contracts.Enums;

/// <summary>PostgreSQL: payment_status</summary>
public enum PaymentStatus
{
    Pending             = 0,
    Approved            = 1,
    Rejected            = 2,
    Refunded            = 3,
    PendingConfirmation = 4
}
