namespace YMI.YmiInfrastructure.CommandQuery;

public class VideosGetAllQryHandler : IRequestHandler<VideosGetAllQry, List<Video>>
{
    private readonly IRepository<Video> _repository;
    public VideosGetAllQryHandler(IRepository<Video> repository)
    {
        _repository = repository;
    }
    public async Task<List<Video>> Handle(VideosGetAllQry qry, CancellationToken cancellationToken)
    {
        var videosGetAllSpec = new VideosGetAllSpec();
        return await _repository.ListAsync(videosGetAllSpec, cancellationToken);
    }
}