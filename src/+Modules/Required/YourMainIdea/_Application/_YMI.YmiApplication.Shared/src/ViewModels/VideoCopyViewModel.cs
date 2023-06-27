namespace YMI.YmiApplication.Shared.ViewModels;
public class VideoCopyViewModel : BaseViewModelTracked<Guid>
{
    public VideoViewModel Video { get; set; }
    public int CopySequence { get; set; }
    public VideoCondition Condition { get; set; }

}
