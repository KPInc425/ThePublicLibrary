namespace TPL.Infrastructure.CommandQuery;

public class MembershipsGetAllQueryHandler : IRequestHandler<MembershipsGetAllQuery, List<Membership>>
{
    private readonly IRepository<Membership> _repository;
    public MembershipsGetAllQueryHandler(IRepository<Membership> repository)
    {
        _repository = repository;
    }
    public async Task<List<Membership>> Handle(MembershipsGetAllQuery qry, CancellationToken cancellationToken)
    {
        return await _repository.ListAsync(cancellationToken);
    }
}