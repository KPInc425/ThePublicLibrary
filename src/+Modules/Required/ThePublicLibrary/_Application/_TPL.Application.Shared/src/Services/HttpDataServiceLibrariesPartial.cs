namespace TPL.Application.Shared.Services;
public partial class HttpDataService
{
   /*  public async Task<List<Library>> LibrariesGetAllAsync()
    {
        var request = new LibrariesGetAllQuery();
        var response = await _httpClient.GetAsync(request.BuildRouteFrom());

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<Library>>();
    }     */
}
