namespace Dedo.Contracts.DTOs.Events;

public abstract record BaseEvent
{
    public Guid     EventId    { get; init; } = Guid.NewGuid();
    public DateTime OccurredAt { get; init; } = DateTime.UtcNow;
    public string   EventType  => GetType().Name;
}
