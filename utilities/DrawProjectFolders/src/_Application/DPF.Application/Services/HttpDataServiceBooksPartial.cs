namespace Dpf.Application.Services;
public partial class HttpDataService
{
    public async Task<List<DpfDirectory>> DpfDirectoriesGetAllAsync()
    {
        var request = new DpfDirectoriesGetAllQuery();
        var response = await _httpClient.GetAsync(request.BuildRouteFrom());

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<DpfDirectory>>();
    }
}
