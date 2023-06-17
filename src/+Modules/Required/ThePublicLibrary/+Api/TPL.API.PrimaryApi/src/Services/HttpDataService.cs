namespace TPL.API.PrimaryApi.Services;
public partial class HttpDataService : IDataService, IDataServiceNotAuthed
{
    protected readonly HttpClient _httpClient;

    public HttpDataService(HttpClient httpClient)
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
