namespace YMI.YmiCore.Entities;
public class VideoCopyGetAllSpec : Specification<Video>
{
    public VideoCopyGetAllSpec()
    {
        Query
            .Include(rs => rs.VideoCopies.Where(rs => rs.Condition != VideoCondition.Destroyed))
            .OrderBy(rs => rs.VideoCopies.Select(rs => rs.CopySequence));
    }
}
