namespace YMI.YmiCore.Entities;
public class VideoStore : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Name { get; private set; }
    public PhysicalAddyVO Address { get; private set; }
    private VideoStore() { }
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
