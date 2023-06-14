namespace TPL.Core.Entities;
public class BooksFindByAuthorSpec : Specification<Book>
{
    public BooksFindByAuthorSpec(string searchString)
    {
        Query
            .Where(s => s.BookAuthors.Any(rs => rs.Author.ToString().ToLower().Contains(searchString.ToLower())));
    }
}
