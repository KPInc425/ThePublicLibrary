
namespace YMI.YmiCore.UnitTests;

public class VideoConstructorTests : BaseVideosTest
{
    [Fact]
    public void CanCreateVideo()
    {
        // When I create a test video
        ICreateAVideo(VideoYmiTestData.VideoAlfradoTheGreat);

        // Then the test video has the correct data
        _videoToTestWith!.Should().NotBeNull();
    }

    [Fact]
    public void CanCreateVideoWithCopies()
    {
        // When I create a video with many copies
        ICreateAVideo(VideoYmiTestData.VideoManyCopies);

        // And test video has the correct video copies
        _videoToTestWith!.VideoCopies.Count().Should().Be(VideoYmiTestData.VideoManyCopies.VideoCopies.Count());

    }

    [Fact]
    public void CanCreateVideoWithCategories()
    {
        // When I set test data to a video with categories
        ICreateAVideo(VideoYmiTestData.VideoWithCategories);

        // Then video has the correct video categories
        _videoToTestWith!.VideoCategories!.Count().Should().Be(VideoYmiTestData.VideoWithCategories.VideoCategories!.Count());
    }
}