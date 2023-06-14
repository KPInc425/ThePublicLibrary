namespace TPL.Application.ViewModels;
public class BookCategoryViewModel : BaseViewModelTracked<Guid>
{
    public string Title { get; set; }
    public List<BookInCategoryViewModel> BookInCategories = new();
}
