namespace YMI.YmiApplication.Shared.ViewModels;
public class VideoCategoryViewModel : BaseViewModelTracked<Guid>
{
    public string Title { get; set; } = string.Empty;
    public List<Video> Videos { get; set; } = new();
}
