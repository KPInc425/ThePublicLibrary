namespace TPL.KnownAccounts.Infrastructure.Data;
// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(KnownAccountsDbContext dbContext) : base(dbContext)
    {
        
    }
}
