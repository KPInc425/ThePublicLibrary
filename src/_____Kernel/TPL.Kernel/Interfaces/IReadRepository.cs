namespace TPL.Kernel.Interfaces;
public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
