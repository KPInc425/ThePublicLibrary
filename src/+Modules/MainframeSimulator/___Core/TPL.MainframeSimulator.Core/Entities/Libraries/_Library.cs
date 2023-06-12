namespace TPL.Core.Entities;
public class Library : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Name { get; private set; }
    public PhysicalAddressVO Address { get; set; }
    public Library(string name)
    {
        Name = Guard.Against.NullOrEmpty(name, "Library name is required");
    }
    private List<Book> _books = new();
    public IEnumerable<Book> Books => _books.AsReadOnly();


    public void AddBookToInventory(Book book)
    {
        _books.Add(book);
    }
    public void AddBookToInventory(IEnumerable<Book> books)
    {
        _books.AddRange(books);
    }

    public void RemoveBook(Book book)
    {
        _books.Remove(book);
    }    
}
