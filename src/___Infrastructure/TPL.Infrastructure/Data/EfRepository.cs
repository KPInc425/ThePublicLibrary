namespace TPL.Infrastructure.Data;
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(TplPrimaryDbContext dbContext) : base(dbContext)
    {
    }
}
