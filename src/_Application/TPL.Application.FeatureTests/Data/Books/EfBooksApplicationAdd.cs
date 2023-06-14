namespace TPL.Application.FeatureTests.Data.Books;
public class EfBookApplicationAdd : BaseApplicationTestFixture
{
    [Fact]
    public async Task AddBook()
    {
        var cmd = new BookAddCommand(_bookTestData.BookAlfradoTheGreat);

        (await _dataService.BooksGetAllAsync(new BooksGetAllQuery())).Count.Should().Be(0, "because we haven't added any books yet");
        await _dataService.BookAddAsync(cmd);
        
        var qry = new BooksGetAllQuery();
        var result = (await _dataService.BooksGetAllAsync(qry)).FirstOrDefault();
        result.Should().NotBeNull("because we just added a book");
        (await _dataService.BooksGetAllAsync(new BooksGetAllQuery())).Count.Should().Be(1, "because we added a single book");


        result.Isbn.Should().Be(_bookTestData.BookAlfradoTheGreat.Isbn);
        result.Title.Should().Be(_bookTestData.BookAlfradoTheGreat.Title);
        result.Condition.Should().Be(_bookTestData.BookAlfradoTheGreat.Condition);
    }
}
