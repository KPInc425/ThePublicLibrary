namespace TPL.Core.Entities;
public class BookCopy : BaseEntityTracked<Guid>
{
    public Book Book { get;  private set; } = null!;

    public int CopySequence { get;  private set; }
    public BookCondition Condition { get; private set; } = BookCondition.New;

    private BookCopy() { }
    public BookCopy(Book book, BookCondition condition = BookCondition.New)
    {
        Book = Guard.Against.Null(book);
        Condition = condition;

        CopySequence = book.BookCopies.Count() + 1;
    }
    public BookCopy(Book book, BookCopy bookCopy)
    {
        Book = Guard.Against.Null(book);

        Condition = bookCopy.Condition;

        CopySequence = book.BookCopies.Count() + 1;
    }
    public void ChangeCondition(BookCondition condition)
    {
        Condition = condition;
    }
}
