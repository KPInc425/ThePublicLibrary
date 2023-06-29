namespace YMI.YmiApplication.Shared.ViewModels;
public class VideoStoreViewModel : BaseViewModelTracked<Guid>
{
    public string Name { get; set; } = string.Empty;
    public PhysicalAddyVOViewModel Address { get; set; } = new();
    public List<VideoViewModel> Videos { get; set; } = new();
}
