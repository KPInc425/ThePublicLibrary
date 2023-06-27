namespace YMI.YmiApplication.FeatureTests.Data.Videos;
public class EfVideoApplicationAdd : BaseApplicationTestFixture
{
    [Fact]
    public async Task AddVideo()
    {

        var result = await _dataService.VideosGetAllAsync(new VideosGetAllQry());
        result.Count.Should().Be(0, "because we haven't added any videos yet");

        var cmd = new VideoAddCmd(VideoYmiTestData.VideoAlfradoTheGreat);
        await _dataService.VideoAddAsync(cmd);

        var qry = new VideosGetAllQry();
        result = (await _dataService.VideosGetAllAsync(qry));
        var resultFirst = result.FirstOrDefault();
        var resultFirstCopy = resultFirst?.VideoCopies.FirstOrDefault();

        result.Should().NotBeNull("because we just added a video");
        resultFirst.VideoCopies.Count.Should().Be(1, "because we added a single video");

        resultFirst.Isbn.ToString().Should().Be(VideoYmiTestData.VideoAlfradoTheGreat.Isbn.ToString());
        resultFirst.Title.Should().Be(VideoYmiTestData.VideoAlfradoTheGreat.Title);
        resultFirstCopy.Condition.Should().Be(VideoYmiTestData.VideoAlfradoTheGreat.VideoCopies.First().Condition);
    }
}
