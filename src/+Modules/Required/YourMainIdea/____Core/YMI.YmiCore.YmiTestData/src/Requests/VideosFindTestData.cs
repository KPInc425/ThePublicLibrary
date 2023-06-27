namespace YMI.YmiCore.YmiTestData.Requests;
public class VideosFindYmiTestData : IYmiTestData
{
    public VideosFindSpec FindByTitleSpec { get; set; }
    public VideosFindSpec FindByTitleAndActorsSpec { get; set; }
    public VideosFindSpec FindByTitleAndActorsAndCategoriesSpec { get; set; }

    public IEnumerable<VideosFindSpec> AllVideosFindSpecs { get; set; }

    public VideosFindYmiTestData()
    {
        FindByTitleSpec = new VideosFindSpec("alf", null, null, null);
        FindByTitleAndActorsSpec = new VideosFindSpec("a", new List<string> { "a" }, null, null);
        FindByTitleAndActorsAndCategoriesSpec = new VideosFindSpec("a", new List<string> { "a" }, new List<string> { "a" }, null);

        AllVideosFindSpecs = new List<VideosFindSpec> {
            FindByTitleSpec,
            FindByTitleAndActorsSpec,
            FindByTitleAndActorsAndCategoriesSpec
        };
    }
}
