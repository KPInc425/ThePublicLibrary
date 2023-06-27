namespace YMI.YmiCore.UnitTests;

public class VideoStoreCheckoutTests
{
    [Fact]
    public void VideoStoreMembersCanCheckoutVideosIfTheyAreInTheVideoStoresInventory()
    {
        // Given I have a videoStore
        // And I have videos in the videoStore's inventory
        // When a member checks out a video
        // Then the VideoStore should have the video in inventory
        // And the Video should now be checked out
        // And the Members should have the video in their CheckedOutVideos

    }
}