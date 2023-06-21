namespace TPL.Application.Shared.Services;
public partial class HttpDataService
{
    public async Task<List<BookViewModel>> BooksGetAllAsync(BooksGetAllQry qry)
    {
        var response = await _httpClient.GetAsync(qry.BuildRouteFrom());

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<BookViewModel>>();
    }

     public async Task<BookViewModel> BookAddAsync(BookAddCmd cmd)
    {
        var response = await _httpClient.PostAsJsonAsync(cmd.BuildRouteFrom(), cmd);

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<BookViewModel>();
    }
}
