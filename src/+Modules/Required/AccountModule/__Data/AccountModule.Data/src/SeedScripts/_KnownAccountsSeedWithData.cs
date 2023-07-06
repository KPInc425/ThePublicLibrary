namespace AccountModule.Data.SeedScripts;
public class KnownAccountsSeedWithData : IAccountModuleSeedScript
{
    public async Task PopulateAccountModuleTestData(IServiceProvider serviceProvider)
    {
        /* var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<BooksSeedWithData>>();
        using var dbContext =
                new KnownAccountDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<KnownAccountDbContext>>(
                        ), mediator);
        
        foreach (var book in BookAccountModuleTestData.AllBooks)
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
        } */
    }
}
