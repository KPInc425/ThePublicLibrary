namespace TPL.TplInfrastructure.IntegrationTests.Data.Books;
public class EfBookRepositoryAdd : BaseTestFixture
{
    [Fact]
    public async Task AddsBookSetsId()
    {
        var repository = BookRepository();
        var Book = BookTplTestData.BookAlfradoTheGreat;

        await repository.AddAsync(Book);

        var newBook = (await repository.ListAsync())
                        .FirstOrDefault();

        Assert.NotNull(newBook?.Id);
    }
}
