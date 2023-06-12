using Ardalis.HttpClientTestExtensions;

namespace TPL.PrimaryApi.FunctionalTests.ControllerTests;
[Collection("Sequential")]
public class BooksControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;

    public BooksControllerTests(CustomWebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task ReturnsOneBook()
    {
        var response = await _client.GetAsync(new BooksGetAllQuery().BuildRouteFrom());
        response.EnsureSuccessStatusCode();

        var result = await response
            .Content
            .ReadFromJsonAsync<IEnumerable<Book>>();

        Assert.Single(result);
        // Assert.Contains(result, i => i.Name == SeedBookData.TestBook1.Name);
    }
}
