namespace TPL.KnownAccounts.Core.Entities;
public class ValidSubscription : BaseEntityTracked<Guid>, IAggregateRoot
{
    private ValidSubscription() { }
    public ValidSubscription(string name)
    {
        Name = Guard.Against.NullOrEmpty(name, nameof(name));        
    }

    public ValidSubscription(Guid id, string name) : this(name)
    {
        Id = Guard.Against.NullOrEmpty(id, nameof(id));
    }


    [MaxLength(100)]
    public string Name { get; private set; } ="";

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
