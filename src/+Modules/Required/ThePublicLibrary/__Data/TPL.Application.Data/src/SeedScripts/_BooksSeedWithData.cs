namespace TPL.Application.Data.SeedScripts;
public class BooksSeedWithData : ISeedScript
{
    public async Task PopulateTestData(IServiceProvider serviceProvider)
    {
        var bookTestData = new BookTestData();
        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<BooksSeedWithData>>();
        using var dbContext =
                new TplPrimaryDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<TplPrimaryDbContext>>(
                        ), mediator);
        if (bookTestData is null)
        {
            throw new NullReferenceException("Book Test Data is null");
        }
        else
        {
            logger?.LogInformation("Book Test data is available");
        }
        foreach (var book in bookTestData.AllBooks)
        {
            if (!dbContext.Books.AsEnumerable().Any(rs => book.Isbn.Equals(rs.Isbn)))
            {
                dbContext.Books.Add(book);
                logger?.LogInformation("{book.Title} was created in the database.", book.Title);
            }
            else
            {
                logger?.LogInformation("{book.Title} already exist in the database.", book.Title);
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
