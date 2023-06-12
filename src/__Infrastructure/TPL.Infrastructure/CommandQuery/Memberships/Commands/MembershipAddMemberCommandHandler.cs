namespace TPL.Infrastructure.CommandQuery;
public class MembershipAddMemberCommandHandler : IRequestHandler<MembershipAddMemberCommand, Membership>
{
    private readonly IRepository<Membership> _repository;
    public MembershipAddMemberCommandHandler(IRepository<Membership> repository)
    {
        _repository = repository;
    }
    public async Task<Membership> Handle(MembershipAddMemberCommand request, CancellationToken cancellationToken)
    {
        return null;
        /* var newMembership = new Membership(request.Name, request.Description, request.Price, request.DurationInMonths, request.Discount);
        return await _repository.AddAsync(newMembership); */
    }
}
