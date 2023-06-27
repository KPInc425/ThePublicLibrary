namespace YMI.YmiInfrastructure.CommandQuery;
public class VideoAddCmd : IRequest<Video>
{
    [Required]
    public string Isbn { get; set; }
    [Required]
    public string Title { get; set; }
    public List<Actor> Actors { get; set; } = new();
    public List<VideoCopy> VideoCopies { get; set; } = new();
    public int PublicationYear { get; set; }
    public int PageCount { get; set; }

    public VideoAddCmd(string isbn, string title, List<Actor> actors, List<VideoCopy> videoCopies, int publicationYear, int pageCount)
    {
        Isbn = isbn;
        Title = title;
        Actors = actors;
        VideoCopies = videoCopies;
        PublicationYear = publicationYear;
        PageCount = pageCount;
    }
    public VideoAddCmd(Video video)
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
}
