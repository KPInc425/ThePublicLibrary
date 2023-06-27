namespace YMI.YmiInfrastructure.CommandQuery;

public class VideosFindQryHandler : IRequestHandler<VideosFindQry, List<Video>>
{
    private readonly IRepository<Video> _repository;
    public VideosFindQryHandler(IRepository<Video> repository)
    {
        _repository = repository;
    }
    public async Task<List<Video>> Handle(VideosFindQry qry, CancellationToken cancellationToken)
    {
        var videosFindSpec = new VideosFindSpec(qry.TitleSearch, qry.ActorSearch, qry.CategorySearch, qry.ConditionSearch);
        return await _repository.ListAsync(videosFindSpec, cancellationToken);
    }
}