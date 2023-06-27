
namespace YMI.YmiCore.UnitTests;

public class VideoFindTests : BaseVideosTest
{
    public static TheoryData<int, string, IEnumerable<string>?, IEnumerable<string>?, IEnumerable<string>?, int?, int?> CanFindVideoByTitleData =>
    new()
    {

            { VideoYmiTestData.AllVideos.Count(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)), "a", null, null, null, 0, int.MaxValue},
            { VideoYmiTestData.AllVideos.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(2).Take(2).Count(), "a", null, null, null, 2, 2},
            { VideoYmiTestData.AllVideos.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(1).Take(3).Count(), "a", null, null, null, 1, 3},
            { VideoYmiTestData.AllVideos.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(2).Take(2).Count(), "a", null, null, null, 2, 2},
            //{ VideoYmiTestData.AllVideos.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(3).Take(2).Count(), "a", null, null, null, 3, 2},
            { VideoYmiTestData.AllVideos.Count(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)), "a", null, null, null, null, null},
            { 2, "a", null, null, null, null, 2},
            //{ VideoYmiTestData.AllVideos.Where(rs=>rs.Title.Contains("a", StringComparison.OrdinalIgnoreCase)).OrderBy(rs=>rs.Title).Skip(3).Take(1).Count(), "a", null, null, null, 3, 1},
            { 0, "a", null, null, null, 500, 1},


            { 1, VideoYmiTestData.VideoJumpingForJax.Title, null, null, null, 0, int.MaxValue},

            {1, VideoYmiTestData.VideoWithCategories.Title, VideoYmiTestData.VideoWithCategories.Actors!.Select(rs=>rs.Name.ToString()), null, null, 0, int.MaxValue},
            {1, VideoYmiTestData.VideoWithCategories.Title, VideoYmiTestData.VideoWithCategories.Actors!.Select(rs=>rs.Name.ToString().Substring(1,rs.Name.ToString().Length-1)), null, null, 0, int.MaxValue},

            { 1, VideoYmiTestData.VideoOfFantasy.Title, VideoYmiTestData.VideoOfFantasy.Actors!.Select(rs=>rs.Name.ToString()), VideoYmiTestData.VideoOfFantasy.VideoCategories!.Select(rs=>rs.Title.ToString()), null, 0, int.MaxValue},
            { 1, VideoYmiTestData.VideoOfFantasy.Title, VideoYmiTestData.VideoOfFantasy.Actors!.Select(rs=>rs.Name.ToString()), VideoYmiTestData.VideoOfFantasy.VideoCategories!.Select(rs=>rs.Title.ToString().Substring(1, rs.Title.ToString().Length-1)), null, 0, int.MaxValue},
            { 1, VideoYmiTestData.VideoOfFantasy.Title, VideoYmiTestData.VideoOfFantasy.Actors!.Select(rs=>rs.Name.ToString()), new List<string> {"fan"}, null, 0, int.MaxValue},

            {1, VideoYmiTestData.VideoWithCategories.Title, VideoYmiTestData.VideoWithCategories.Actors!.Select(rs=>rs.Name.ToString()), VideoYmiTestData.VideoWithCategories.VideoCategories!.Select(rs=>rs.Title.ToString()), new List<string>{ VideoCondition.Good.ToString()}, 0, int.MaxValue}
        };
    [Theory]
    [MemberData(nameof(CanFindVideoByTitleData))]
    public void CanFindVideoByTitle(int expectedResultCount, string titleSearch, IEnumerable<string>? actorSearch, IEnumerable<string>? categorySearch, IEnumerable<string>? conditionSearch, int? paginationPage = 0, int? paginationTake = int.MaxValue)
    {
        // build the spec from theory data
        var findSpec = new VideosFindSpec(titleSearch, actorSearch, categorySearch, conditionSearch, paginationPage, paginationTake);

        // Get the test data
        var allVideos = VideoYmiTestData.AllVideos;

        // When I evaluate the find by title spec
        _videosToTestWith = findSpec.Evaluate(allVideos).ToList();

        // Then the test video has the correct data
        _videosToTestWith.Should().NotBeNull();
        _videosToTestWith!.Count().Should().Be(expectedResultCount);
    }

    [Fact]
    public void CanCreateVideoWithCopies()
    {
        // When I create a video with many copies
        ICreateAVideo(VideoYmiTestData.VideoManyCopies);

        // And test video has the correct video copies
        _videoToTestWith.VideoCopies.Count().Should().Be(VideoYmiTestData.VideoManyCopies.VideoCopies.Count());
    }

    [Fact]
    public void CanCreateVideoWithCategories()
    {
        // When I set test data to a video with categories
        ICreateAVideo(VideoYmiTestData.VideoWithCategories);

        // Then video has the correct video categories
        _videoToTestWith.VideoCategories.Count().Should().Be(VideoYmiTestData.VideoWithCategories.VideoCategories.Count());
    }
}