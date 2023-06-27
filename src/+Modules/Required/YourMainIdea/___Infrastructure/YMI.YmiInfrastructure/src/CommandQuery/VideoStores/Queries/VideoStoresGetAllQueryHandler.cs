namespace YMI.YmiInfrastructure.CommandQuery;

public class VideoStoresGetAllQueryHandler : IRequestHandler<VideoStoresGetAllQuery, List<VideoStore>>
{
    private readonly IRepository<VideoStore> _repository;
    public VideoStoresGetAllQueryHandler(IRepository<VideoStore> repository)
    {
        _repository = repository;
    }
    public async Task<List<VideoStore>> Handle(VideoStoresGetAllQuery qry, CancellationToken cancellationToken)
    {
        return await _repository.ListAsync(cancellationToken);
    }
}