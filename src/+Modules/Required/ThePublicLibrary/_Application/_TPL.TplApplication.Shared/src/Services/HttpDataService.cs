namespace TPL.TplApplication.Shared.Services;
public partial class TplHttpDataService : ITplDataService, ITplDataServiceNotAuthed
{
    protected readonly HttpClient _httpClient;

    public TplHttpDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }



    public Task<List<LibraryViewModel>> LibrariesGetAllAsync(LibrariesGetAllQuery qry)
    {
        throw new NotImplementedException();
    }

    public Task<List<MemberViewModel>> MembersGetAllAsync(MembersGetAllQuery qry)
    {
        throw new NotImplementedException();
    }

    public Task<List<MembershipViewModel>> MembershipsGetAllAsync(MembershipsGetAllQuery qry)
    {
        throw new NotImplementedException();
    }
}
