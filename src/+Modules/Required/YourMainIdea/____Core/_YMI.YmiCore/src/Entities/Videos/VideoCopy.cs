namespace YMI.YmiCore.Entities;
public class VideoCopy : BaseEntityTracked<Guid>
{
    public Guid VideoId { get; init; }
    public Video Video { get; init; }

    public int CopySequence { get; private set; }
    public VideoCondition Condition { get; private set; } = VideoCondition.New;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private VideoCopy() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public VideoCopy(Video video, VideoCondition videoCondition) : this(null, video, videoCondition) { }
    public VideoCopy(Guid videoId, VideoCondition videoCondition) : this(videoId, null, videoCondition) { }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private VideoCopy(Guid? VideoId, Video? video, VideoCondition condition = VideoCondition.New)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
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
        CopySequence = video!.VideoCopies.Count() + 1;
    }
    
    public void ChangeCondition(VideoCondition condition)
    {
        Condition = condition;
    }
}
