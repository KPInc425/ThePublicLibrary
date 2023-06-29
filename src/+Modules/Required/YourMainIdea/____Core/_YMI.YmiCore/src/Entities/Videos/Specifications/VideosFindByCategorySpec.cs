namespace YMI.YmiCore.Entities;
public class VideosFindByCategorySpec : Specification<Video>
{
    public VideosFindByCategorySpec(string searchString)
    {
        Query
            .Where(rs => rs.VideoCategories != null && rs.VideoCategories.Any(rss => rss.Title.Contains(searchString)))
            .OrderBy(rs => rs.VideoCategories != null ? rs.VideoCategories.Select(rss => rss.Title).ToString() : rs.Id);
    }
}
