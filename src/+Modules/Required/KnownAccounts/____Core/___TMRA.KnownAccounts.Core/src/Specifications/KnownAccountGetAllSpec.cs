namespace TPL.KnownAccounts.Core.Specifications;
public class KnownAccountGetAllSpec : Specification<KnownAccount>
{
    public KnownAccountGetAllSpec()
    {
        Query
            .AsNoTracking()
            ;
    }
}
