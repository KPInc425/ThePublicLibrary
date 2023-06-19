namespace TPL.Application.Shared.Interfaces;

public partial interface IDataService {
    Task<List<MemberViewModel>> MembersGetAllAsync(MembersGetAllQuery qry);
}