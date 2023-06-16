namespace TPL.Application.Data.SeedScripts;
public class LibrariesSeedWithData : ISeedScript
{
    public async Task PopulateTestData(IServiceProvider serviceProvider)
    {
        var libraryTestData = new LibraryTestData();

        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<BooksSeedWithData>>();

        using var dbContext =
                new TplPrimaryDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<TplPrimaryDbContext>>(
                        ), mediator);

        if (libraryTestData is null)
        {
            throw new NullReferenceException("Library Test Data is null");
        }

        if (!dbContext.Libraries.Any())
        {
            dbContext.Libraries.AddRange(libraryTestData.AllLibraries);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded All Library Data");
        }

        if (dbContext.Libraries.FirstOrDefault(rs => rs.Name == libraryTestData.FirstStreetLibraryName) is null)
        {
            dbContext.Libraries.Add(libraryTestData.FirstStreetLibrary);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded Single Library Data");
        }
    }
}
