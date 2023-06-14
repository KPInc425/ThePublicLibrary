namespace TPL.Core.Entities;

public class BookAuthor : BaseEntityTracked<Guid>, IAggregateRoot
{
    [Key]
    public Book Book { get; }
    [Key]
    public Author Author { get; }

    private BookAuthor() { }
    public BookAuthor(Book book, Author author)
    {
        Book = book;
        Author = author;
    }
}
