namespace TPL.Application.Interfaces;

public partial interface IDataService {
    Task<List<MemberViewModel>> MembersGetAllAsync(MembersGetAllQuery qry);
}