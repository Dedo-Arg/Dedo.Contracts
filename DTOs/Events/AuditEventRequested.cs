using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record AuditEventRequested(
    Guid?                       UserId,
    AuditEventType              AuditType,
    OperationStatus             Status,
    string?                     Detail   = null,
    Dictionary<string, string>? Metadata = null
) : BaseEvent;
