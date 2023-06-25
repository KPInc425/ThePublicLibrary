namespace TPL.TplInfrastructure.CommandQuery;

public class MembersGetAllQueryHandler : IRequestHandler<MembersGetAllQuery, List<Member>>
{
    private readonly IRepository<Member> _repository;
    public MembersGetAllQueryHandler(IRepository<Member> repository)
    {
        _repository = repository;
    }
    public async Task<List<Member>> Handle(MembersGetAllQuery qry, CancellationToken cancellationToken)
    {
        return await _repository.ListAsync(cancellationToken);
    }
}