namespace TPL.Application.ViewModels;
public class LibraryShelfViewModel : BaseViewModelTracked<Guid>
{
    public string Name { get; set; }
    public PhysicalAddressVOViewModel Address { get; set; }
    public List<BookViewModel> Books = new();

}
