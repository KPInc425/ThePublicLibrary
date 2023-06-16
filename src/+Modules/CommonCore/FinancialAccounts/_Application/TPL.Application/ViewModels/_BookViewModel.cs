namespace TPL.Application.ViewModels;
public class BookViewModel : BaseViewModelTracked<Guid>
{
    public string Isbn { get; set; }
    public string Title { get; set; }
    public BookCondition Condition { get; set; }

    public List<BookCategoryViewModel> BookCategories = new();
}
