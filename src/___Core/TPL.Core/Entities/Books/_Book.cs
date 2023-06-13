namespace TPL.Core.Entities;
public class Book : BaseEntityTracked<Guid>, IAggregateRoot
{
    public IsbnVO Isbn { get; }
    public string Title { get; }
    public Author Author { get; }
    public int PublicationYear { get; }
    public int PageCount { get; }

    private List<BookCategory> _bookCategories = new();
    public IEnumerable<BookCategory> BookCategories => _bookCategories.AsReadOnly();

    private List<BookCopy> _bookCopies = new();
    public IEnumerable<BookCopy> BookCopies => _bookCopies.AsReadOnly();

    private Book() { }
    public Book(IsbnVO isbn, string title, Author author, int publicationYear, int pageCount)
    {
        Isbn = isbn;
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        PageCount = pageCount;
    }
    public void AddBookCopy(int copySequence, BookCondition condition = BookCondition.New)
    {
        var bookCopy = new BookCopy(copySequence, condition);
        _bookCopies.Add(bookCopy);
    }
    public void RemoveBookCopy(BookCopy bookCopy)
    {
        _bookCopies.Remove(bookCopy);
    }
}
