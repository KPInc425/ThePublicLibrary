namespace TPL.KnownAccounts.Core.Entities;
public class KnownUserFilter : BaseEntityTracked<Guid>, IAggregateRoot
{
    private KnownUserFilter() { }
    public KnownUserFilter(string name)
    {
        Name = Guard.Against.NullOrEmpty(name, nameof(name));
    }

    public KnownUserFilter(Guid id, string name) : this(name)
    {
        Id = Guard.Against.NullOrEmpty(id, nameof(id));
    }
    
    public string Name { get; private set; } = "";

    
    public bool IsActive { get; private set; } = true;

    public void Inactivate()
    {
        IsActive = false;
    }
    public void Activate()
    {
        IsActive = true;
    }    
}
