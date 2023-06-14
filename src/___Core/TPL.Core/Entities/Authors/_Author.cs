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
        return Name.ToString();
    }
    public bool ContainsInsensitive(string searchString)
    {
        var lowerName = Name.ToString().ToLower();
        return lowerName.Contains(searchString);
    }
}
