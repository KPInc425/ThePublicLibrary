namespace Dpf.Application.Services;
public partial class HttpDataService : IDataService
{
    protected readonly HttpClient _httpClient;

    public HttpDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }   
}
