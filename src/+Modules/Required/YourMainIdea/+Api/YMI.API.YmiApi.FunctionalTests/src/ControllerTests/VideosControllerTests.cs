namespace YMI.API.YmiApi.FunctionalTests.ControllerTests;

[Collection("Sequential")]
public class VideosControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;
    public VideosControllerTests(CustomWebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task ReturnsAllVideos()
    {
        var response = await _client.GetAsync(new VideosGetAllRequest().BuildRouteFrom());
        response.EnsureSuccessStatusCode();

        var raw = await response.Content.ReadAsStringAsync();
        var result = await response
            .Content
            .ReadFromJsonAsync<IEnumerable<VideoViewModel>>();

        result.Should().HaveCount(VideoYmiTestData.AllVideos.Count()-1);
        // Assert.Contains(result, i => i.Name == SeedVideoData.TestVideo1.Name);
    }

    [Fact]
    public async Task ReturnsVideoSearchResults()
    {
        var response = await _client.GetAsync(new VideosFindByTitleRequest("a").BuildRouteFrom());
        response.EnsureSuccessStatusCode();

        var raw = await response.Content.ReadAsStringAsync();
        var result = await response
            .Content
            .ReadFromJsonAsync<IEnumerable<VideoViewModel>>();

        result.Should().HaveCountGreaterThan(0);
        // Assert.Contains(result, i => i.Name == SeedVideoData.TestVideo1.Name);
    }
}
