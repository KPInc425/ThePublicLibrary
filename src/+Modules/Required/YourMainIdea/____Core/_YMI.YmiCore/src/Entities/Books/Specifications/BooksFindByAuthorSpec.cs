namespace YMI.YmiCore.Entities;
public class BooksFindByAuthorSpec : Specification<Book>
{
    public BooksFindByAuthorSpec(string searchString)
    {
        Query
            .Where(s => s.Authors.Any(rs => rs.ToString().ToLower().Contains(searchString.ToLower())));
    }
}
