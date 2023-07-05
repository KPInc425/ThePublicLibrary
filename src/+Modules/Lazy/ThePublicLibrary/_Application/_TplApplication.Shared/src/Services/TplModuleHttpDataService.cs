namespace TplApplication.Shared.Services;
public partial class TplModuleHttpDataService : ITplDataService, ITplDataServiceNotAuthed
{
    protected readonly HttpClient _httpClient;

    public TplModuleHttpDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
