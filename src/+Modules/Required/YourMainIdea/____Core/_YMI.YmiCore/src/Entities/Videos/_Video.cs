namespace YMI.YmiCore.Entities;

public class Video : BaseEntityTracked<Guid>, IAggregateRoot
{

    public IsbnVO Isbn { get; init; }
    public string Title { get; private set; }
    public int PublicationYear { get; private set; }
    public int PageCount { get; private set; }

    private readonly List<Actor> _actors = new();
    public IEnumerable<Actor>? Actors => _actors.AsReadOnly();

    private readonly List<VideoCategory> _videoCategories = new();
    public IEnumerable<VideoCategory>? VideoCategories => _videoCategories.AsReadOnly();

    private List<VideoCopy> _videoCopies = new();
    public IEnumerable<VideoCopy> VideoCopies => _videoCopies.Where(rs => rs.Condition != VideoCondition.Destroyed).ToList().AsReadOnly();

    private Video() { }

    public Video(IsbnVO isbn, IEnumerable<Actor> actors, IEnumerable<VideoCategory>? videoCategories, IEnumerable<VideoCopy>? videoCopies, string title, int publicationYear, int pageCount)
    {
        Isbn = Guard.Against.Null(isbn, "because isbn is required");
        Title = Guard.Against.NullOrEmpty(title, "because title is required");
        PublicationYear = Guard.Against.Null(publicationYear, "because publicationYear is required");
        PageCount = Guard.Against.Null(pageCount, "because page count is required");

        Guard.Against.Null(actors, "because actors is required");
        
        _actors.AddRange(actors);
        if (videoCopies is not null)
        {
            _videoCopies.AddRange(videoCopies);
        }
        if (videoCategories is not null)
        {
            _videoCategories.AddRange(videoCategories);
        }
    }
    
    //Video/AddVideoCopy(VideoAddVideoCopyRequest videoAddVideoCopyRequest)[Result<Video>]
    public void AddVideoCopy(VideoCondition condition = VideoCondition.New)
    {
        var videoCopy = new VideoCopy(this, condition);
        _videoCopies.Add(videoCopy);
    }

    //Video/RemoveVideoCopy(VideoRemoveVideoCopy videoRemoveVideoCopy)[Result<Video>]
    public void RemoveVideoCopy(VideoCopy videoCopy)
    {
        videoCopy.ChangeCondition(VideoCondition.Destroyed);
    }

    //Video/AddVideoCategory(VideoAddVideoCategory videoAddVideoCategory)[Result<Video>]
    public void AddVideoCategory(VideoCategory videoCategory)
    {
        if (!_videoCategories.Contains(videoCategory))
        {
            _videoCategories.Add(videoCategory);
        }
    }

    //Video/AddActor(VideoAddVideoActorRequest videoAddVideoActorRequest)[Result<Video>]
    public void AddVideoActor(Actor actor)
    {
        if (_actors.Any(x => x.Id == actor.Id))
        {
            return;
        }
        _actors.Add(actor);
    }

    //Video/RemoveVideoActor(VideoRemoveVideoActorRequest videoRemoveVideoActorRequest)[Result<Video>]
    public void RemoveVideoActor(Actor actor)
    {
        if (_actors.Any(x => x.Id == actor.Id))
        {
            _actors.Remove(actor);
        }
    }
    
    //Video/RemoveVideoCategory(VideoRemoveVideoCategoryRequest videoRemoveVideoCategoryRequest)[Result<Video>]
    public void RemoveVideoCategory(string categoryTitle)
    {
        var videoCategory = _videoCategories.FirstOrDefault(x => x.Title == categoryTitle);
        if (videoCategory != null)
        {
            _videoCategories.Remove(videoCategory);
        }
    }

    public override string ToString()
    {
        return $"{Title} ({Isbn}) ({PublicationYear}) ({PageCount}) ({Actors.Select(x => x.ToString() + ", ")}) ({VideoCategories.Select(x => x.Title + ", ")})";
    }
}
