namespace TplApplication.Shared.Services;
public partial class TplHttpDataService : ITplDataService, ITplDataServiceNotAuthed
{
    protected readonly HttpClient _httpClient;

    public TplHttpDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
