namespace TPL.Core.Entities;
public class BookCopyGetAllSpec : Specification<Book>
{
    public BookCopyGetAllSpec()
    {
        Query
            .Include(rs => rs.BookCopies.Where(rs => rs.Condition != BookCondition.Destroyed))
            .OrderBy(rs => rs.BookCopies.Select(rs => rs.CopySequence));
    }
}
