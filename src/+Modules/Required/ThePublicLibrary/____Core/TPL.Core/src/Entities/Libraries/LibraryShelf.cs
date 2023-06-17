namespace TPL.Core.Entities;
public class LibraryShelf : BaseEntityTracked<Guid>
{
    public string Name { get; private set; }
    public Library Library { get; private set; }
    public PhysicalAddressVO Address { get; private set; }
    public LibraryShelf(Library library, string name)
    {
        // thinking about something fun
        Library.Should().NotBeNull("Library is required");

        Library = Guard.Against.Null(library, "Library is required");
        Name = Guard.Against.NullOrEmpty(name, "Shelf name is required");
    }
    private List<Book> _books = new();
    public IEnumerable<Book> Books => _books.AsReadOnly();


    public void AddBookToShelf(Book book)
    {
        _books.Add(book);
    }
    public void AddBookToShelf(IEnumerable<Book> books)
    {
        _books.AddRange(books);
    }

    public void RemoveBookFromShelf(Book book)
    {
        _books.Remove(book);
    }
}
