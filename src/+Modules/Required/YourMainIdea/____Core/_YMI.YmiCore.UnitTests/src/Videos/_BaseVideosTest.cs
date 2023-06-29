namespace YMI.YmiCore.UnitTests;
public abstract class BaseVideosTest
{
    protected IsbnVO? _videoIsbn;
    protected Video? _videoToTestWith;
    protected List<Video> _videosToTestWith = new();
    protected VideoCopy? _videoCopyToTestWith;
    protected List<Actor>? _videoActorsToTestWith;
    protected List<VideoCategory>? _videoCategoriesToTestWith;

    protected void ICreateAVideo(Video video)
    {
        _videoToTestWith = new Video(
            video.Isbn,
            video.Actors!,
            video.VideoCategories,
            video.VideoCopies,
            video.Title,
            video.PublicationYear,
            video.PageCount);

        _videoToTestWith.Should().NotBeNull();
        _videoToTestWith.Isbn.Should().Be(video.Isbn);
        _videoToTestWith.Actors!.Count().Should().Be(video.Actors!.Count());
        _videoToTestWith.VideoCategories!.Count().Should().Be(video.VideoCategories!.Count());
        _videoToTestWith.VideoCopies.Count().Should().Be(video.VideoCopies.Count());
        _videoToTestWith.Title.Should().Be(video.Title);
        _videoToTestWith.PublicationYear.Should().Be(video.PublicationYear);
        _videoToTestWith.PageCount.Should().Be(video.PageCount);
    }
    protected void ICreateManyVideos(IEnumerable<Video> videos)
    {
        foreach (var video in videos)
        {
            var newVideo = new Video(
                video.Isbn,
                video.Actors!,
                video.VideoCategories,
                video.VideoCopies,
                video.Title,
                video.PublicationYear,
                video.PageCount);

            newVideo.Should().NotBeNull();
            newVideo.Isbn.Should().Be(video.Isbn);
            newVideo.Actors!.Count().Should().Be(video.Actors!.Count());
            newVideo.VideoCategories!.Count().Should().Be(video.VideoCategories!.Count());
            newVideo.VideoCopies.Count().Should().Be(video.VideoCopies.Count());
            newVideo.Title.Should().Be(video.Title);
            newVideo.PublicationYear.Should().Be(video.PublicationYear);
            newVideo.PageCount.Should().Be(video.PageCount);
            _videosToTestWith.Add(newVideo);
        }
        _videosToTestWith.Count().Should().Be(videos.Count());
    }
    protected void IHaveAVideoCopyOfCondition(VideoCondition condition)
    {
        _videoCopyToTestWith = _videoToTestWith!.VideoCopies.FirstOrDefault(rs => rs.Condition == condition);
        _videoCopyToTestWith.Should().NotBeNull();
        _videoCopyToTestWith!.Condition.Should().Be(VideoCondition.Good);

    }
    protected void IHaveVideoCategories()
    {
        if (_videoToTestWith!.VideoCategories!.Count() == 0)
        {
            _videoToTestWith.AddVideoCategory(VideoYmiTestData.VideoCategoryFiction);
            _videoToTestWith.AddVideoCategory(VideoYmiTestData.VideoCategoryFantasy);
        }
    }
}
