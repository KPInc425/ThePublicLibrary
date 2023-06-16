namespace TPL.Infrastructure.CommandQuery;

public class DpfDirectoriesGetAllQueryHandler : IRequestHandler<DpfDirectoriesGetAllQuery, List<DpfDirectory>>
{
    private readonly IRepository<DpfDirectory> _repository;
    public DpfDirectoriesGetAllQueryHandler(IRepository<DpfDirectory> repository)
    {
        _repository = repository;
    }
    public async Task<List<DpfDirectory>> Handle(DpfDirectoriesGetAllQuery qry, CancellationToken cancellationToken)
    {
        var getAllQuerySpec = new DpfDirectoriesGetAllSpec();
        return await _repository.ListAsync(getAllQuerySpec, cancellationToken);
    }
}