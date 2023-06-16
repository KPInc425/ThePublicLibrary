namespace TPL.Core.Entities;
public class Book : BaseEntityTracked<Guid>, IAggregateRoot
{
    public IsbnVO Isbn { get; }
    public string Title { get; }
    public int PublicationYear { get; }
    public int PageCount { get; }

    private List<Author> _authors = new();
    public IEnumerable<Author> Authors => _authors.AsReadOnly();

    private List<BookCategory> _bookCategories = new();
    public IEnumerable<BookCategory> BookCategories => _bookCategories.AsReadOnly();

    private List<BookCopy> _bookCopies = new();
    public IEnumerable<BookCopy> BookCopies => _bookCopies.Where(rs => rs.Condition != BookCondition.Destroyed).ToList().AsReadOnly();

    private Book() { }

    public Book(IsbnVO isbn, IEnumerable<Author> authors, IEnumerable<BookCopy>? bookCopies, string title, int publicationYear, int pageCount)
    {
        Isbn = isbn;
        Title = title;
        PublicationYear = publicationYear;
        PageCount = pageCount;

        _authors.AddRange(authors);
        if (bookCopies is not null)
        {
            _bookCopies.AddRange(bookCopies);
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

    public void AddBookAuthor(Author author)
    {
        if(_authors.Any(x => x.Id == author.Id))
        {
            return;
        }
        _authors.Add(author);
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
        return $"{Title} ({Isbn}) ({PublicationYear}) ({PageCount}) ({Authors.Select(x => x.ToString())}) ({BookCategories.Select(x => x.Title + ", ")})";
    }
}
