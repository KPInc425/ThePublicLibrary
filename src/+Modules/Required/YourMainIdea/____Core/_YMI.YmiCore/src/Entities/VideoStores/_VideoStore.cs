namespace YMI.YmiCore.Entities;
public class VideoStore : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Name { get; private set; }
    public PhysicalAddyVO Address { get; private set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private VideoStore() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public VideoStore(string name, PhysicalAddyVO address)
    {
        Name = Guard.Against.NullOrEmpty(name, "VideoStore name is required");
        Address = Guard.Against.Null(address, "VideoStore address is required");
    }
    private List<Video> _videos = new();
    public IEnumerable<Video> Videos => _videos.AsReadOnly();


    public void AddVideoToInventory(Video video)
    {
        _videos.Add(video);
    }
    public void AddVideoToInventory(IEnumerable<Video> videos)
    {
        _videos.AddRange(videos);
    }

    public void RemoveVideo(Video video)
    {
        _videos.Remove(video);
    }
}
