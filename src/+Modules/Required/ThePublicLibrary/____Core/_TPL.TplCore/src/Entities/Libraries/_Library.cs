namespace TPL.TplCore.Entities;
public class Library : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Name { get; private set; }
    public PhysicalAddressVO Address { get; private set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Library() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Library(string name, PhysicalAddressVO address)
    {
        Name = Guard.Against.NullOrEmpty(name, "Library name is required");
        Address = Guard.Against.Null(address, "Library address is required");
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
