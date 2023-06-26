namespace YMI.YmiCore.Entities;
public class BookCopy : BaseEntityTracked<Guid>
{
    public Guid BookId { get; init; }
    public Book Book { get; init; }

    public int CopySequence { get; private set; }
    public BookCondition Condition { get; private set; } = BookCondition.New;

    private BookCopy() { }
    public BookCopy(Book book, BookCondition bookCondition) : this(null, book, bookCondition) { }
    public BookCopy(Guid bookId, BookCondition bookCondition) : this(bookId, null, bookCondition) { }
    private BookCopy(Guid? BookId, Book? book, BookCondition condition = BookCondition.New)
    {
        if(BookId.HasValue) {
            BookId = BookId.Value;
        }

        if(book is not null) {
            Book = book;
        }
        if (!BookId.HasValue && book is null) {
            throw new ArgumentException("BookId or Book must be set");
        }

        Condition = condition;
        CopySequence = book.BookCopies.Count() + 1;
    }
    
    public void ChangeCondition(BookCondition condition)
    {
        Condition = condition;
    }
}
