namespace Frenweh.KernelShared.Interfaces;
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}