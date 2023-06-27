namespace YMI.YmiCore.Entities;
public class VideoCategory : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Title { get; private set; }
    private VideoCategory(){}
    public VideoCategory(string title)
    {
        Title = title;
    }
    private List<VideoCategory> _videoCategories = new();
    public IEnumerable<VideoCategory> VideoCategories => _videoCategories.AsReadOnly();
}
