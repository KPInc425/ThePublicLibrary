namespace YMI.YmiApplication.Shared.Requests;
public class VideoAddRequest : IYmiRoutable
{
    protected static string Route = "/video/add";
    [Required]
    public string Isbn { get; set; }
    [Required]
    public string Title { get; set; }
    public List<Actor> Actors { get; set; } = new();
    public List<VideoCopy> VideoCopies { get; set; } = new();
    public int PublicationYear { get; set; }
    public int PageCount { get; set; }

    public VideoAddRequest(string isbn, string title, List<Actor> actors, List<VideoCopy> videoCopies, int publicationYear, int pageCount)
    {
        Isbn = isbn;
        Title = title;
        Actors = actors;
        VideoCopies = videoCopies;
        PublicationYear = publicationYear;
        PageCount = pageCount;
    }
    public VideoAddRequest(Video video)
    {
        Isbn = video.Isbn.ToString();
        Title = video.Title;
        PublicationYear = video.PublicationYear;
        PageCount = video.PageCount;

        Actors.AddRange(video.Actors);

        if (video.VideoCopies is not null)
        {
            VideoCopies.AddRange(video.VideoCopies);
        }

    }
    public string BuildRouteFrom()
    {
        return VideoAddRequest.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
