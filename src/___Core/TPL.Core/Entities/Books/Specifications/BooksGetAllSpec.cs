namespace TPL.Core.Entities;
public class BooksGetAllSpec : Specification<Book>
{
    public BooksGetAllSpec()
    {
        Query
            .OrderBy(s => s.BookAuthors.Select(rs=>rs.ToString()));
    }
}
