namespace TPL.TplCore.Entities;
public class MembersFindByNameSpec : Specification<Member>
{
    public MembersFindByNameSpec(string searchString)
    {
        Query
            .Where(s => s.Name.ToString().Contains(searchString))
            .OrderBy(s => s.Name.ToString());
    }
}
