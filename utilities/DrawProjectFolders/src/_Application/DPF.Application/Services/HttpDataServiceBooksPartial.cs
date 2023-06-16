namespace Dpf.Application.Services;
public partial class HttpDataService
{
    public async Task<List<DpfDirectoryViewModel>> DpfDirectoriesGetAllAsync(DpfDirectoriesGetAllQuery qry)
    {
        var response = await _httpClient.GetAsync(qry.BuildRouteFrom());

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<DpfDirectory>>();
    }

     public async Task<DpfDirectoryViewModel> DpfDirectoryAddAsync(DpfDirectoryAddCommand cmd)
    {
        var response = await _httpClient.PostAsJsonAsync(cmd.BuildRouteFrom(), cmd);

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<DpfDirectory>();
    }
}
