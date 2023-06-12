namespace TPL.Application.FeatureTests.Data.Books;
public class EfBookApplicationAdd : BaseApplicationTestFixture
{
    [Fact]
    public async Task AddBook()
    {
        var cmd = new BookAddCommand(_bookTestData.AlfradoTheGreat);

        (await _dataService.BooksGetAllAsync(new BooksGetAllQuery())).Count.Should().Be(0, "because we haven't added any books yet");
        await _dataService.BookAddAsync(cmd);
        
        var qry = new BooksGetAllQuery();
        var result = (await _dataService.BooksGetAllAsync(qry)).FirstOrDefault();
        result.Should().NotBeNull("because we just added a book");
        (await _dataService.BooksGetAllAsync(new BooksGetAllQuery())).Count.Should().Be(1, "because we added a single book");


        result.ISBN.Should().Be(_bookTestData.AlfradoTheGreat.ISBN);
        result.Title.Should().Be(_bookTestData.AlfradoTheGreat.Title);
        result.Condition.Should().Be(_bookTestData.AlfradoTheGreat.Condition);
    }
}
