namespace YMI.YmiCore.Entities;
public class NewActorAddedEvent : BaseDomainEvent
{
    public FullNameVO Name { get; set; }
    public NewActorAddedEvent(FullNameVO name)
    {
        Name = name;
    }
}