namespace TPL.Core.Entities;
public class BooksFindByTitleSpec : Specification<Book>
{
    public BooksFindByTitleSpec(string searchString)
    {
        Query
            .Where(s => s.Title.Contains(searchString))
            .OrderBy(s => s.Title);
    }
}
