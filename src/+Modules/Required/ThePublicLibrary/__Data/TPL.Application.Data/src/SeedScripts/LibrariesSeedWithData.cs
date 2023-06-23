namespace TPL.Application.Data.SeedScripts;
public class LibrariesSeedWithData : ISeedScript
{
    public async Task PopulateTestData(IServiceProvider serviceProvider)
    {
        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<BooksSeedWithData>>();

        using var dbContext =
                new TplPrimaryDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<TplPrimaryDbContext>>(
                        ), mediator);

       
        if (!dbContext.Libraries.Any())
        {
            dbContext.Libraries.AddRange(LibraryTestData.AllLibraries);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded All Library Data");
        }

        if (dbContext.Libraries.FirstOrDefault(rs => rs.Name == LibraryTestData.FirstStreetLibraryName) is null)
        {
            dbContext.Libraries.Add(LibraryTestData.FirstStreetLibrary);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded Single Library Data");
        }
    }
}
