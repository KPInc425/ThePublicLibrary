namespace TPL.Core.Entities;
public class KnownAccount : BaseEntityTracked<Guid>, IAggregateRoot
{
    public NameVO Name { get; }
    private KnownAccount() { }
    public KnownAccount(NameVO name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return $"{Name}";
    }
}
