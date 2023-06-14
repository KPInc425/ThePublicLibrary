namespace TPL.Application.ViewModels;
public class BookInCategoryViewModel : BaseViewModelTracked<Guid>
{
    public BookViewModel Book { get; set; }
    public BookCategoryViewModel BookCategory { get; set; }

}
