namespace YMI.YmiCore.Entities;
public class VideoCopy : BaseEntityTracked<Guid>
{
    public Guid VideoId { get; init; }
    public Video Video { get; init; }

    public int CopySequence { get; private set; }
    public VideoCondition Condition { get; private set; } = VideoCondition.New;

    private VideoCopy() { }
    public VideoCopy(Video video, VideoCondition videoCondition) : this(null, video, videoCondition) { }
    public VideoCopy(Guid videoId, VideoCondition videoCondition) : this(videoId, null, videoCondition) { }
    private VideoCopy(Guid? VideoId, Video? video, VideoCondition condition = VideoCondition.New)
    {
        if(VideoId.HasValue) {
            VideoId = VideoId.Value;
        }

        if(video is not null) {
            Video = video;
        }
        if (!VideoId.HasValue && video is null) {
            throw new ArgumentException("VideoId or Video must be set");
        }

        Condition = condition;
        CopySequence = video.VideoCopies.Count() + 1;
    }
    
    public void ChangeCondition(VideoCondition condition)
    {
        Condition = condition;
    }
}
