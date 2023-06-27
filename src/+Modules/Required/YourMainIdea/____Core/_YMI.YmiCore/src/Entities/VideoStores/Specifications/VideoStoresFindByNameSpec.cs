namespace YMI.YmiCore.Entities;
public class VideoStoresFindByNameSpec : Specification<VideoStore>
{
    public VideoStoresFindByNameSpec(string searchString)
    {
        Query
            .Where(s => s.Name.Contains(searchString))
            .OrderBy(s => s.Name);
    }
}
