namespace TPL.Core.Entities;
public class MembershipFindByNameSpec : Specification<Membership>
{
    public MembershipFindByNameSpec(string searchString)
    {
        Query
            .Where(rs=>rs.MembershipTitle.Contains(searchString))
            .OrderBy(s => s.MembershipTitle);
    }
}
