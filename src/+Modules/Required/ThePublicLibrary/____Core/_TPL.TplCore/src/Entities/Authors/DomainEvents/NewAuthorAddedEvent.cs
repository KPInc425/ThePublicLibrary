namespace TPL.TplCore.Entities;
public class NewAuthorAddedEvent : BaseDomainEvent
{
    public NameVO Name { get; set; }
    public NewAuthorAddedEvent(NameVO name)
    {
        Name = name;
    }
}