namespace YMI.YmiCore.UnitTests.Videos
{
    public class VideoCopyTests : BaseVideosTest
    {
        [Fact]
        public void VideoStoreCanHaveMultipleCopiesOfTheSameVideo()
        {
            // Given I have a video with no copies
            ICreateAVideo(VideoYmiTestData.VideoNoCopies);
            _videoToTestWith!.VideoCopies.Should().BeEmpty();

            // When I add a video copy
            _videoToTestWith!.AddVideoCopy(VideoCondition.Good);

            // Then there should be on copy of the video
            _videoToTestWith!.VideoCopies.Should().NotBeEmpty();
            _videoToTestWith!.VideoCopies.Count().Should().Be(1);
        }
    }
}