namespace TPL.Core.Entities;

public class Book : BaseEntityTracked<Guid>, IAggregateRoot
{

    public IsbnVO Isbn { get; private set; }
    public string Title { get; private set; }
    public int PublicationYear { get; private set; }
    public int PageCount { get; private set; }

    private List<Author> _authors = new();
    public IEnumerable<Author> Authors => _authors.AsReadOnly();

    private List<BookCategory> _bookCategories = new();
    public IEnumerable<BookCategory> BookCategories => _bookCategories.AsReadOnly();

    private List<BookCopy> _bookCopies = new();
    public IEnumerable<BookCopy> BookCopies => _bookCopies.Where(rs => rs.Condition != BookCondition.Destroyed).ToList().AsReadOnly();

    private Book() { }

    public Book(IsbnVO isbn, IEnumerable<Author> authors, IEnumerable<BookCategory>? bookCategories, IEnumerable<BookCopy>? bookCopies, string title, int publicationYear, int pageCount)
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
        if (bookCategories is not null)
        {
            _bookCategories.AddRange(bookCategories);
        }
    }

    public void AddBookCopy(BookCondition condition = BookCondition.New)
    {
        var bookCopy = new BookCopy(this, condition);
        _bookCopies.Add(bookCopy);
    }
    public void RemoveBookCopy(BookCopy bookCopy)
    {
        bookCopy.ChangeCondition(BookCondition.Destroyed);
    }

    public void AddBookCategory(BookCategory bookCategory)
    {
        if (!_bookCategories.Contains(bookCategory))
        {
            _bookCategories.Add(bookCategory);
        }
    }

    public void AddBookAuthor(Author author)
    {
        if (_authors.Any(x => x.Id == author.Id))
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

    public override string ToString()
    {
        return $"{Title} ({Isbn}) ({PublicationYear}) ({PageCount}) ({Authors.Select(x => x.ToString() + ", ")}) ({BookCategories.Select(x => x.Title + ", ")})";
    }
}
