namespace TPL.Application.Services;
public partial class DirectDataService
{
    public async Task<List<MembershipViewModel>> MembershipsGetAllAsync(MembershipsGetAllQuery qry)
    {
        return _mapper.Map<List<MembershipViewModel>>(await _mediator.Send(qry));
    }
}
