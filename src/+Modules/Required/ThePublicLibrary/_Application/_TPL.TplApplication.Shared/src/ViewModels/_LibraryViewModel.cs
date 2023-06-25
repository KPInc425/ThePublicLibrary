namespace TPL.TplApplication.Shared.ViewModels;
public class LibraryViewModel : BaseViewModelTracked<Guid>
{
    public string Name { get; set; }
    public PhysicalAddressVOViewModel Address { get; set; }
    public List<BookViewModel> Books { get; set; } = new();
}
