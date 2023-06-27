namespace YMI.YmiApplication.Shared.ViewModels;
public class VideoStoreViewModel : BaseViewModelTracked<Guid>
{
    public string Name { get; set; }
    public PhysicalAddyVOViewModel Address { get; set; }
    public List<VideoViewModel> Videos { get; set; } = new();
}
