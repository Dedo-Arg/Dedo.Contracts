namespace Dedo.Contracts.DTOs.Events;

public abstract record BaseEvent
{
    public Guid           EventId    { get; init; } = Guid.NewGuid();
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;
    public string         EventType  => GetType().Name;
}
