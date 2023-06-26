namespace YMI.YmiCore.Entities;
public class NewAuthorAddedEvent : BaseDomainEvent
{
    public NameVO Name { get; set; }
    public NewAuthorAddedEvent(NameVO name)
    {
        Name = name;
    }
}