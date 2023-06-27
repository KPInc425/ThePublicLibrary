namespace YMI.YmiInfrastructure.CommandQuery;

public class VideosFindByTitleQryHandler : IRequestHandler<VideosFindByTitleQry, List<Video>>
{
    private readonly IRepository<Video> _repository;
    public VideosFindByTitleQryHandler(IRepository<Video> repository)
    {
        _repository = repository;
    }
    public async Task<List<Video>> Handle(VideosFindByTitleQry qry, CancellationToken cancellationToken)
    {
        var videosFindByTitleSpec = new VideosFindByTitleSpec(qry.SearchFor);
        return await _repository.ListAsync(videosFindByTitleSpec, cancellationToken);
    }
}