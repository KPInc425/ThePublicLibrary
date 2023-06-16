namespace TPL.Application.Services;
public partial class HttpDataService
{
    public async Task<List<Member>> MembersGetAllAsync()
    {
        var request = new MembersGetAllQuery();
        var response = await _httpClient.GetAsync(request.BuildRouteFrom());

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<Member>>();
    }    
}
