namespace YMI.YmiCore.Entities;
public class VideosGetAllSpec : Specification<Video>
{
    public VideosGetAllSpec()
    {
        Query
            .Include(b => b.Actors)
            .Include(b => b.VideoCopies)
            .OrderBy(s => s.Title);
    }
}
