
namespace YMI.YmiApplication.Shared.Services;
public partial class YmiHttpDataService
{
    public async Task<List<VideoViewModel>> VideosGetAllAsync(VideosGetAllQry qry)
    {
        var response = await _httpClient.GetAsync(VideosGetAllRequest.BuildRoute());

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<VideoViewModel>>();
    }

     public async Task<VideoViewModel> VideoAddAsync(VideoAddCmd cmd)
    {
        var response = await _httpClient.PostAsJsonAsync(VideoAddRequest.BuildRoute(), cmd);

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<VideoViewModel>();
    }

     public async Task<List<VideoViewModel>> VideosFindAsync(VideosFindQry qry)
    {
        var response = await _httpClient.PostAsJsonAsync(VideosFindRequest.BuildRoute(qry), qry);

        response.EnsureSuccessStatusCode();

        return await response
            .Content
            .ReadFromJsonAsync<List<VideoViewModel>>();
    }
}
