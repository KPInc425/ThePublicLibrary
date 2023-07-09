namespace YmiCore.UnitTests;

public class VideoConstructorTests
{
    [Fact]
    public void CanSearchForVideo()
    {
        // Given I have a video store
        // And I am looking for a video
        // When I search the stores inventory
        // Then I find 1 or more videos matching my search
    }

    [Fact]
    public void CanCreateVideoStore()
    {
        // Given I have video store data Name, Physical Address, Inventory
        var store1Name = "Store 1";
        var store1AddressLine1 = "123 West Way";

        // When I create the video store
        var videoStoreToTest = new VideoStore(store1Name, store1AddressLine1);

        // Then I have the same video store data
        videoStoreToTest.Should().NotBeNull();
        videoStoreToTest.StoreName.Should().Be(store1Name);
        videoStoreToTest.AddressLine1.Should().Be(store1AddressLine1);
    }    
}