namespace Dpf.Infrastructure.Data;
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(DpfPrimaryDbContext dbContext) : base(dbContext)
    {
    }
}
