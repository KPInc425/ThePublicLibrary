namespace TPL.KnownAccounts.Core.Specifications;
public class KnownBusinessWebsiteGetByIdSpec : Specification<KnownBusinessWebsite>, ISingleResultSpecification
{
    public KnownBusinessWebsiteGetByIdSpec(Guid id)
    {
        Query
            .Include(rs => rs.KnownBusinessWebsiteProfile)
            .Where(rs => rs.Id == id)
        ;
    }
}
