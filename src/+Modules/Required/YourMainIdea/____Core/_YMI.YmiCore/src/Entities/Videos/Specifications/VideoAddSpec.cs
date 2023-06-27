namespace YMI.YmiCore.Entities;
public class VideoAddSpec : Specification<Video>
{
    public VideoAddSpec()
    {
        Query
            .Include(b => b.Actors)
            .Include(b => b.VideoCopies)
            .OrderBy(s => s.Title);
    }
}
