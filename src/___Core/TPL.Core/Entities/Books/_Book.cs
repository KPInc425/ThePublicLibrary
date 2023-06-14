namespace TPL.Core.Entities;
public class Book : BaseEntityTracked<Guid>, IAggregateRoot
{
    public IsbnVO Isbn { get; }
    public string Title { get; }
    public int PublicationYear { get; }
    public int PageCount { get; }

    private List<BookAuthor> _bookAuthors = new();
    public IEnumerable<BookAuthor> BookAuthors => _bookAuthors.AsReadOnly();

    private List<BookCategory> _bookCategories = new();
    public IEnumerable<BookCategory> BookCategories => _bookCategories.AsReadOnly();

    private List<BookCopy> _bookCopies = new();
    public IEnumerable<BookCopy> BookCopies => _bookCopies.Where(rs=>rs.Condition != BookCondition.Destroyed).ToList().AsReadOnly();

    private Book() { }

    public Book(IsbnVO isbn, IEnumerable<Author> authors, string title, int publicationYear, int pageCount)
    {
        //Isbn = isbn;
        Title = title;
        PublicationYear = publicationYear;
        PageCount = pageCount;

        foreach (var author in authors)
        {
            _bookAuthors.Add(new BookAuthor(this, author));
        }
    }

    public void AddBookCopy(BookCondition condition = BookCondition.New)
    {
        var bookCopy = new BookCopy(this, condition);
        _bookCopies.Add(bookCopy);
    }

    public void AddBookCategory(string categoryTitle)
    {
        var bookCategory = _bookCategories.FirstOrDefault(x => x.Title == categoryTitle);
        if (bookCategory is null)
        {
            bookCategory = new BookCategory(categoryTitle);
            _bookCategories.Add(bookCategory);
        }
    }

    public void RemoveBookCategory(string categoryTitle)
    {
        var bookCategory = _bookCategories.FirstOrDefault(x => x.Title == categoryTitle);
        if (bookCategory != null)
        {
            _bookCategories.Remove(bookCategory);
        }
    }

    public void RemoveBookCopy(BookCopy bookCopy)
    {
        bookCopy.SetCondition(BookCondition.Destroyed);
    }

    public override string ToString()
    {
        return $"{Title} ({Isbn}) ({PublicationYear}) ({PageCount}) ({BookAuthors.Select(x => x.ToString())}) ({BookCategories.Select(x => x.Title + ", ")})";
    }
}
