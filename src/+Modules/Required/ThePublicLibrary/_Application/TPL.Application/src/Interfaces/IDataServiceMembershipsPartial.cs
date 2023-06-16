namespace TPL.Application.Interfaces;

public partial interface IDataService {
    Task<List<MembershipViewModel>>MembershipsGetAllAsync(MembershipsGetAllQuery qry);
}