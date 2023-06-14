namespace TPL.Core.Entities;
public class KnownAccountsFindByEmailSpec : Specification<KnownAccount>
{
    public KnownAccountsFindByEmailSpec(string searchString)
    {
        Query
            .Where(s => s.Name.ToString().Contains(searchString))
            .OrderBy(s => s.Name.ToString());
    }
}
