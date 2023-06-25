namespace Frenweh.KernelShared;
public abstract class BaseViewModelTracked<T>
{
    public T Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}
