namespace YMI.YmiCore.UnitTests;

public class VideoStoreInventoryTests
{
    [Fact]
    public void VideoStoreCanHaveAnInventoryOfVideos()
    {
        var videoStore = VideoStoreYmiTestData.FirstStreetVideoStore;
        var video = VideoYmiTestData.VideoAlfradoTheGreat;
        
        videoStore.AddVideoToInventory(video);
        videoStore.Videos.FirstOrDefault(rs => rs.Isbn == video.Isbn && rs.Title == video.Title).Should().NotBeNull();
    }
}
