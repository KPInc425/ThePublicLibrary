namespace TPL.Core.Entities;
public class Book : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string ISBN { get; private set; }
    public string Title { get; private set; }
    public BookCondition Condition { get; private set; }

    private List<BookCategory> _bookCategories = new();
    public IEnumerable<BookCategory> BookCategories => _bookCategories.AsReadOnly();
    private Book(){}
    public Book(string isbn, string title)
    {
        ISBN = isbn;
        Title = title;
    }
    public Book(string isbn, string title, BookCondition condition) : this(isbn, title)
    {
        Condition = condition;
    }
}
