namespace TPL.Core.Entities;
public class Author : BaseEntityTracked<Guid>, IAggregateRoot
{
    public NameVO Name { get; }
    private Author() { }
    public Author(NameVO name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return $"{Name}";
    }
}
