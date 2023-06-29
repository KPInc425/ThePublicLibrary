namespace YMI.YmiCore.Entities;
public class Actor : BaseEntityTracked<Guid>, IAggregateRoot
{
    public FullNameVO Name { get; private set; }

    private readonly List<Video> _videos = new();
    public IEnumerable<Video> Videos => _videos.AsReadOnly();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Actor() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Actor(FullNameVO name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return Name.ToString();
    }
}
