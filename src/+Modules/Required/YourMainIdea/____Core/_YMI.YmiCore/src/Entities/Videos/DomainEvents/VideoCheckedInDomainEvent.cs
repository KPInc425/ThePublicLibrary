namespace YMI.YmiCore.Entities;
public class VideoCheckedInDomainEvent : BaseDomainEvent
{
    public VideoStore VideoStore { get; set; }
    public Video Video { get; set; }
    public VideoCheckedInDomainEvent(VideoStore videoStore, Video video)
    {
        VideoStore = Guard.Against.Null(videoStore, "VideoStore is required");
        Video = Guard.Against.Null(video, "Video is required");
    }
}