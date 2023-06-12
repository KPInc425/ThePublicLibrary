namespace TPL.Core.Entities;
public class BookCategory : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Title { get; private set; }
    private BookCategory(){}
    public BookCategory(string title)
    {
        Title = title;
    }
    private List<BookInCategory> _bookInCategories = new();
    public IEnumerable<BookInCategory> BookInCategories => _bookInCategories.AsReadOnly();
}
