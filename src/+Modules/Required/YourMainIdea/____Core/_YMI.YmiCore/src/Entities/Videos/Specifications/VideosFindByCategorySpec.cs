namespace YMI.YmiCore.Entities;
public class VideosFindByCategorySpec : Specification<Video>
{
    public VideosFindByCategorySpec(string searchString)
    {
        Query
            .Where(s => s.VideoCategories.Any(rs => rs.Title.Contains(searchString)))
            .OrderBy(rs => rs.VideoCategories.Select(s => s.Title).ToString());
    }
}
