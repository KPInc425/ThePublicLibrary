namespace Dpf.Application.ViewModels;
public class DpfDirectoryViewModel : BaseViewModelTracked<long>
{
    public DpfDirectory? Parent { get; set; }

    public string Name { get; }
    public string FullName { get; }

    public int FileCount { get; }
    public long TotalSizeOnDisk { get; set; }


    public readonly List<DpfFileViewModel> DpsFiles = new();
    public readonly List<DpfDirectoryViewModel> Children = new();
}
