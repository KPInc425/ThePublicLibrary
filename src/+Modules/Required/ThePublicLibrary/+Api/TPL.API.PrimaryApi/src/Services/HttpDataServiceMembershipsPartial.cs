namespace TPL.API.PrimaryApi.Services;
public partial class HttpDataService
{
    public async Task<List<Membership>> MembershipsGetAllAsync()
    {
        var request = new MembershipsGetAllQuery();
        var response = await _httpClient.GetAsync(request.BuildRouteFrom());

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<Membership>>();
    }
}
