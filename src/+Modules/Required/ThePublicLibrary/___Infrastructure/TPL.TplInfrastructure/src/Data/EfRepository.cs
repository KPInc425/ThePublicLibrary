namespace TPL.TplInfrastructure.Data;
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(TplDbContext dbContext) : base(dbContext)
    {
    }
}
