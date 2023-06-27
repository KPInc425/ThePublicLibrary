namespace YMI.YmiCore.Entities;
public class VideosFindByTitleSpec : Specification<Video>
{
    public VideosFindByTitleSpec(string searchString)
    {
        Query
            .Where(s => s.Title.Contains(searchString))
            .OrderBy(s => s.Title);
    }
}
