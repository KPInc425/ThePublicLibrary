namespace YMI.YmiCore.Entities;
public class BooksFindByCategorySpec : Specification<Book>
{
    public BooksFindByCategorySpec(string searchString)
    {
        Query
            .Where(s => s.BookCategories.Any(rs => rs.Title.Contains(searchString)))
            .OrderBy(rs => rs.BookCategories.Select(s => s.Title).ToString());
    }
}
