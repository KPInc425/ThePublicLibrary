namespace TPL.Application.ViewModels;
public class LibrarySectionViewModel : BaseViewModelTracked<Guid>
{
    public string Name { get; set; }
    public List<LibraryShelfViewModel> Shelves = new();
}
