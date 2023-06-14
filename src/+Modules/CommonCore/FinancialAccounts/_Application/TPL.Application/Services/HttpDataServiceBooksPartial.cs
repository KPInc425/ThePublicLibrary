namespace TPL.Application.Services;
public partial class HttpDataService
{
    public async Task<List<Book>> BooksGetAllAsync()
    {
        var request = new BooksGetAllQuery();
        var response = await _httpClient.GetAsync(request.BuildRouteFrom());

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<Book>>();
    }
}
