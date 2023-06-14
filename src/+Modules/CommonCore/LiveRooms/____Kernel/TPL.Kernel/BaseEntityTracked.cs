namespace TPL.Kernel;
public abstract class BaseEntityTracked<T>
{
    public T Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
    
    public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();        
}
