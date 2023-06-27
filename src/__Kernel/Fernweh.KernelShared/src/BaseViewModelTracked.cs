namespace Fernweh.KernelShared;
public abstract class BaseViewModelTracked<T>
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public T Id { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}
