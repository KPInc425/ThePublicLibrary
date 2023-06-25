namespace TPL.TplCore.Entities;
public class MembershipsFindByNameSpec : Specification<Membership>
{
    public MembershipsFindByNameSpec(string searchString)
    {
        Query
            .Where(rs=>rs.MembershipTitle.Contains(searchString))
            .OrderBy(s => s.MembershipTitle);
    }
}
