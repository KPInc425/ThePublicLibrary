namespace TPL.Infrastructure.CommandQuery;

public class MembershipsFindByNameQueryHandler : IRequestHandler<MembershipsFindByNameQuery, List<Membership>>
{
    private readonly IRepository<Membership> _repository;
    public MembershipsFindByNameQueryHandler(IRepository<Membership> repository)
    {
        _repository = repository;
    }
    public async Task<List<Membership>> Handle(MembershipsFindByNameQuery qry, CancellationToken cancellationToken)
    {
        var membershipsFindByNameSpec = new MembershipsFindByNameSpec(qry.SearchFor);
        return await _repository.ListAsync(membershipsFindByNameSpec, cancellationToken);
    }
}