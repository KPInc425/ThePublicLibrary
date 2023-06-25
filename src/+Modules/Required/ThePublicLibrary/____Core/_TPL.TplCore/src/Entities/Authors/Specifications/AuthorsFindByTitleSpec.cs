namespace TPL.TplCore.Entities;
public class AuthorsFindByTitleSpec : Specification<Author>
{
    public AuthorsFindByTitleSpec(string searchString)
    {
        Query
            .Where(s => s.Name.ToString().Contains(searchString))
            .OrderBy(s => s.Name.ToString());
    }
}
