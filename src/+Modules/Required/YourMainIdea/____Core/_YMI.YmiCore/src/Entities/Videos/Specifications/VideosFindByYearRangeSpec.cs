namespace YMI.YmiCore.Entities;
public class VideosFindByYearRangeSpec : Specification<Video>
{
    public VideosFindByYearRangeSpec(int startYearInclusive, int endYearInclusive)
    {
        Query
            .Where(rs => rs.PublicationYear >= startYearInclusive && rs.PublicationYear <= endYearInclusive)
            .OrderBy(rs => rs.PublicationYear);
    }
}
