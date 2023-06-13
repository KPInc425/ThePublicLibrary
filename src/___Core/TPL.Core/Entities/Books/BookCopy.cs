namespace TPL.Core.Entities;
public class BookCopy : BaseEntityTracked<Guid>
{
    public Book Book { get; } = null!;

    public int CopySequence { get; } = 1;
    public BookCondition Condition { get; private set; } = BookCondition.New;

    private BookCopy() { }
    public BookCopy(int copySequence = 1, BookCondition condition = BookCondition.New)
    {
        CopySequence = copySequence;
        Condition = condition;
    }
    public void SetCondition(BookCondition condition)
    {
        Condition = condition;
    }
}
