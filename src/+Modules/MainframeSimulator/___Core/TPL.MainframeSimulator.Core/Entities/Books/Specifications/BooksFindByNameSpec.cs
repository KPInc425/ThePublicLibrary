namespace TPL.Core.Entities;
public class BooksFindByNameSpec : Specification<Book>
{
    public BooksFindByNameSpec(string searchString)
    {
        Query
            .Where(s => s.Title.Contains(searchString))
            .OrderBy(s => s.Title);
    }
}
