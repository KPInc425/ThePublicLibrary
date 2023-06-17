namespace TPL.Core.Entities;
public class Author : BaseEntityTracked<Guid>, IAggregateRoot
{
    public NameVO Name { get; private set; }

    private readonly List<Book> _books = new();
    public IEnumerable<Book> Books => _books.AsReadOnly();

    private Author() { }
    public Author(NameVO name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return Name.ToString();
    }
}
