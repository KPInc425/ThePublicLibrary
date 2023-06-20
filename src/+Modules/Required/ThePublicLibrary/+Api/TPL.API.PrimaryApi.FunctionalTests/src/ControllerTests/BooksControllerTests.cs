namespace TPL.API.PrimaryApi.FunctionalTests.ControllerTests;

[Collection("Sequential")]
public class BooksControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;
    private readonly BookTestData _bookTestData = new();

    public BooksControllerTests(CustomWebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task ReturnsOneBook()
    {
        var response = await _client.GetAsync(new BooksGetAllQuery().BuildRouteFrom());
        response.EnsureSuccessStatusCode();

        var raw = await response.Content.ReadAsStringAsync();
        var result = await response
            .Content
            .ReadFromJsonAsync<IEnumerable<BookViewModel>>();

        result.Should().HaveCount(_bookTestData.AllBooks.Count());
        // Assert.Contains(result, i => i.Name == SeedBookData.TestBook1.Name);
    }

    [Fact]
    public async Task ReturnsBookSearchResults()
    {
        var response = await _client.GetAsync(new BooksFindByTitleQuery("a").BuildRouteFrom());
        response.EnsureSuccessStatusCode();

        var raw = await response.Content.ReadAsStringAsync();
        var result = await response
            .Content
            .ReadFromJsonAsync<IEnumerable<BookViewModel>>();

        result.Should().HaveCountGreaterThan(0);
        // Assert.Contains(result, i => i.Name == SeedBookData.TestBook1.Name);
    }
}
