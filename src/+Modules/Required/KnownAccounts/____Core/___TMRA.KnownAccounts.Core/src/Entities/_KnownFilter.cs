namespace TPL.KnownAccounts.Core.Entities;
public class KnownFilter : BaseEntityTracked<Guid>, IAggregateRoot
{
    private KnownFilter() { }
    public KnownFilter(string name)
    {
        Name = Guard.Against.NullOrEmpty(name, nameof(name));        
    }

    public KnownFilter(Guid id, string name, string emailAddress) : this(name)
    {
        Id = Guard.Against.NullOrEmpty(id, nameof(id));
    }
    
    public string Name { get; private set; } = "";

    public bool IsActive { get; private set; } = true;
    public void SetName(string name)
    {
        Name = Guard.Against.NullOrEmpty(name, nameof(name));
    }
    
    public void Inactivate()
    {
        IsActive = false;
    }
    public void Activate()
    {
        IsActive = true;
    }    
}
