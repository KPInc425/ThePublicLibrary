namespace YMI.YmiCore.Entities;
public class VideosFindByActorSpec : Specification<Video>
{
    public VideosFindByActorSpec(string searchString)
    {
        Query
            .Where(s => s.Actors.Any(rs => rs.ToString().ToLower().Contains(searchString.ToLower())));
    }
}
