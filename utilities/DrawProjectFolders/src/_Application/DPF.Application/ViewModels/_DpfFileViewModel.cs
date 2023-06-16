namespace Dpf.Application.ViewModels;
public class DpfFileViewModel : BaseViewModelTracked<long>
{
    public string Name { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Extension { get; set; } = string.Empty;
    public long SizeInBytesOnDisk { get; set; }
    public DpfDirectoryViewModel Directory { get; set; } = null!;
}
