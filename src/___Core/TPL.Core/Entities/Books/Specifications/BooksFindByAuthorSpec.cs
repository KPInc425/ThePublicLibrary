namespace TPL.Core.Entities;
public class BooksFindByAuthorSpec : Specification<Book>
{
    public BooksFindByAuthorSpec(string searchString)
    {
        Query
            .Where(s => s.Author.ToString().Like(searchString))
            .OrderBy(s => s.Author.ToString());
    }
}
