namespace YMI.YmiCore.Entities;
public class VideoCategory : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Title { get; private set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private VideoCategory(){}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public VideoCategory(string title)
    {
        Title = title;
    }
    private List<VideoCategory> _videoCategories = new();
    public IEnumerable<VideoCategory> VideoCategories => _videoCategories.AsReadOnly();
}
