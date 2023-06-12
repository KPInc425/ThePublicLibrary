namespace TPL.Core.Entities;
public class BookInCategory : BaseEntityTracked<Guid>
{
    public Book Book { get; private set; }
    public BookCategory BookCategory { get; private set; }

}
