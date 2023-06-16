namespace TPL.KnownAccounts.Core.Specifications;
public class KnownBusinessWebsiteProfileGetByIdSpec : Specification<KnownBusinessWebsiteProfile>, ISingleResultSpecification
{
    public KnownBusinessWebsiteProfileGetByIdSpec(Guid id)
    {
        Query
            .Where(rs => rs.Id == id)
        ;
    }
}
