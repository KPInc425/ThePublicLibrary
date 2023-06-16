namespace TPL.Core.Entities;
public class BookCategory : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Title { get; private set; }
    private BookCategory(){}
    public BookCategory(string title)
    {
        Title = title;
    }
    private List<BookCategory> _bookCategories = new();
    public IEnumerable<BookCategory> BookCategories => _bookCategories.AsReadOnly();
}
