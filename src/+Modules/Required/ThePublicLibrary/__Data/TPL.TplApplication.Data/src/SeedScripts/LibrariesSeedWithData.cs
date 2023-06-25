namespace TPL.TplApplication.Data.SeedScripts;
public class LibrariesSeedWithData : ITplSeedScript
{
    public async Task PopulateTplTestData(IServiceProvider serviceProvider)
    {
        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<BooksSeedWithData>>();

        using var dbContext =
                new TplDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<TplDbContext>>(
                        ), mediator);

       
        if (!dbContext.Libraries.Any())
        {
            dbContext.Libraries.AddRange(LibraryTplTestData.AllLibraries);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded All Library Data");
        }

        if (dbContext.Libraries.FirstOrDefault(rs => rs.Name == LibraryTplTestData.FirstStreetLibraryName) is null)
        {
            dbContext.Libraries.Add(LibraryTplTestData.FirstStreetLibrary);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded Single Library Data");
        }
    }
}
