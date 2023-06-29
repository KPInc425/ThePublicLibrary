namespace YMI.YmiApplication.Shared.ViewModels;
public class VideoCopyViewModel : BaseViewModelTracked<Guid>
{
    public VideoViewModel Video { get; set; } = new();
    public int CopySequence { get; set; }
    public VideoCondition Condition { get; set; } = VideoCondition.New;

}
