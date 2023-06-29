namespace YMI.YmiCore.UnitTests;

public class VideoSearchTests : BaseVideosTest
{
    
    [Fact]
    public void CanSearchVideosByYearRange()
    {
        // Given I have videos
        ICreateManyVideos(VideoYmiTestData.AllVideos);

        // Given I have a search by year range specification
        var startYear = 1900;
        var endYear = 2020;

        var searchByYearRangeSpec = new VideosFindByYearRangeSpec(startYear, endYear);

        // When I search for videos in that range
        var videosInRange = searchByYearRangeSpec.Evaluate(_videosToTestWith);

        // Then I find videos in that range
        videosInRange.Should().NotBeEmpty();
        videosInRange.Should().HaveCountGreaterThan(0);

    }

    [Fact]
    public void CanSearchVideosByActor()
    {
        // Given I have actors
        var actors = ActorYmiTestData.AllActors;

        // Given I have videos
        var videos = VideoYmiTestData.AllVideos;
        videos.Should().NotBeEmpty();
        
        // Given we have an actor search string
        var searchFor = "john";
        var videosFindByActor = new VideosFindByActorSpec(searchFor);

        // When I search for videos in that range
        var videosInRange = videosFindByActor.Evaluate(videos);

        // Then I find videos in that range
        videosInRange.Should().NotBeEmpty();
        videosInRange.Should().HaveCountGreaterThan(0);
    }


    [Fact]
    public void CanRemoveDamagedVideoCopies()
    {
        // Given I have a video with multiple copies
        var manyCopiesMax = VideoYmiTestData.VideoManyCopies;
        manyCopiesMax.Should().NotBeNull();

        // And I select the first video copy
        var randomVideoCopy = manyCopiesMax.VideoCopies.FirstOrDefault();
        manyCopiesMax.VideoCopies.Count().Should().BeGreaterThan(1);

        // And I store the number of copies plus one to offset the index
        var numberOfCopies = manyCopiesMax.VideoCopies.Count();

        // When I remove the damaged copy
        manyCopiesMax.RemoveVideoCopy(randomVideoCopy!);

        // Then I should have the same number of copies of the video
        manyCopiesMax.VideoCopies.Count().Should().Be(numberOfCopies - 1);

        // And the damaged copy should be removed
        var spec = new VideoCopyGetAllSpec();
        var videoCopies = spec.Evaluate(new List<Video>() { manyCopiesMax })?.FirstOrDefault()?.VideoCopies;
        videoCopies!.FirstOrDefault(rs=>rs.CopySequence == randomVideoCopy!.CopySequence).Should().BeNull();
    }
}