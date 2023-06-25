namespace TPL.TplInfrastructure.CommandQuery;

public class MembersFindByNameQueryHandler : IRequestHandler<MembersFindByNameQuery, List<Member>>
{
    private readonly IRepository<Member> _repository;
    public MembersFindByNameQueryHandler(IRepository<Member> repository)
    {
        _repository = repository;
    }
    public async Task<List<Member>> Handle(MembersFindByNameQuery qry, CancellationToken cancellationToken)
    {
        var membersFindByNameSpec = new MembersFindByNameSpec(qry.SearchFor);
        return await _repository.ListAsync(membersFindByNameSpec, cancellationToken);
    }
}