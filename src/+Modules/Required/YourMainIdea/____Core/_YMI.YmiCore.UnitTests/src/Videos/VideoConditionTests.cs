namespace YMI.YmiCore.UnitTests;

public class VideoConditionTests : BaseVideosTest
{
    [Fact]
    public void CanChangeVideoCondition()
    {
        // Given I have videos with copies
        ICreateAVideo(VideoYmiTestData.VideoManyCopies);

        // Given I have a video copy that is in good condition
        IHaveAVideoCopyOfCondition(VideoCondition.Good);

        // When I change the condition to poor
        _videoCopyToTestWith.ChangeCondition(VideoCondition.Poor);
        
        // Then the video is now in poor condition
        _videoCopyToTestWith.Condition.Should().Be(VideoCondition.Poor);
    }

    [Fact]
    public void RemoveVideoChangesConditionToDestroyed()
    {
        // Given I have a video with multiple copies
        ICreateAVideo(VideoYmiTestData.VideoManyCopies);

        // And I select the first video copy
        IHaveAVideoCopyOfCondition(VideoCondition.Good);

        // And I store the number of copies not destroyed
        var numberOfCopiesNotDestroyed = _videoToTestWith.VideoCopies.Count(rs=>rs.Condition != VideoCondition.Destroyed);

        // When I remove the damaged copy
        _videoToTestWith.RemoveVideoCopy(_videoCopyToTestWith);

        // Then I should have one fewer copies of the video
        var numberOfCopiesNotDestroyedUpdated = _videoToTestWith.VideoCopies.Count(rs=>rs.Condition != VideoCondition.Destroyed);
        numberOfCopiesNotDestroyedUpdated.Should().Be(numberOfCopiesNotDestroyed - 1);
    }

    
}