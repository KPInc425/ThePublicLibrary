namespace TPL.KnownAccounts.Core.Entities;
public class KnownFilterCategory : BaseEntityTracked<Guid>, IAggregateRoot
{
    private KnownFilterCategory() { }
    public KnownFilterCategory(string name)
    {
        Name = Guard.Against.NullOrEmpty(name, nameof(name));
    }

    public KnownFilterCategory(Guid id, string name) : this(name)
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
