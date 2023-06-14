namespace TPL.Core.Entities;
public class Book : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Isbn { get; private set; }
    public string Title { get; private set; }
    public BookCondition Condition { get; private set; }
    public Book(string isbn, string title)
    {
        Isbn = isbn;
        Title = title;
    }
    public Book(string isbn, string title, BookCondition condition) : this(isbn, title)
    {
        Condition = condition;
    }
}
