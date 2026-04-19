using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record AuditEventRequested(
    Guid?                       UserId,
    AuditEventType              AuditType,
    OperationStatus             Status,
    string?                     Detail   = null,
    IReadOnlyDictionary<string, string>? Metadata = null
) : BaseEvent;
