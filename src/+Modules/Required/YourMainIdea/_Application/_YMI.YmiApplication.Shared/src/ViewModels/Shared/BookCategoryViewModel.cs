namespace YMI.YmiApplication.Shared.ViewModels;
public class BookCategoryViewModel : BaseViewModelTracked<Guid>
{
    public string Title { get; set; }
    public List<Book> Books { get; set; } = new();
}
