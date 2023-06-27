namespace YMI.YmiCore.Entities;
public class Actor : BaseEntityTracked<Guid>, IAggregateRoot
{
    public FullNameVO Name { get; private set; }

    private readonly List<Video> _videos = new();
    public IEnumerable<Video> Videos => _videos.AsReadOnly();

    private Actor() { }
    public Actor(FullNameVO name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return Name.ToString();
    }
}
