namespace YMI.YmiInfrastructure.CommandQuery;
public class VideoAddCmdHandler : IRequestHandler<VideoAddCmd, Video>
{
    private readonly IRepository<Video> _repository;
    public VideoAddCmdHandler(IRepository<Video> repository)
    {
        _repository = repository;
    }
    public async Task<Video> Handle(VideoAddCmd request, CancellationToken cancellationToken)
    {
        var video = new Video(new(request.Isbn), request.Actors, null, request.VideoCopies, request.Title, request.PublicationYear, request.PageCount);
        return await _repository.AddAsync(video, cancellationToken);
    }
}
