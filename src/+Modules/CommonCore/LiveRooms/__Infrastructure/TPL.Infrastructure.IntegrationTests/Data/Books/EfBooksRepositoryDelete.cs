namespace TPL.Infrastructure.IntegrationTests.Data;
public class EfBookRepositoryDelete : BaseTestFixture
{
    [Fact]
    public async Task DeletesItemAfterAddingIt()
    {
      /*   // add a Book
        var repository = BookRepository();
        var initialName = "My Name";
        var initialId = Guid.NewGuid();

        var Book = new Book(initialId, initialName);
        await repository.AddAsync(Book);

        // delete the item
        await repository.DeleteAsync(Book);

        // verify it's no longer there
        Assert.DoesNotContain(await repository.ListAsync(),
            Book => Book.Id == initialId); */
    }
}
