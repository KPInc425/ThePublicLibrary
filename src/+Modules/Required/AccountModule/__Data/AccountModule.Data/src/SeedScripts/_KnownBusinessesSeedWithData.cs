namespace AccountModule.Data.SeedScripts;
public class KnownBusinessesSeedWithData : IAccountModuleSeedScript
{
    public async Task PopulateAccountModuleTestData(IServiceProvider serviceProvider)
    {
        /* var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<BooksSeedWithData>>();

        using var dbContext =
                new KnownAccountDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<KnownAccountDbContext>>(
                        ), mediator);

       
        if (!dbContext.Libraries.Any())
        {
            dbContext.Libraries.AddRange(LibraryAccountModuleTestData.AllLibraries);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded All Library Data");
        }

        if (dbContext.Libraries.FirstOrDefault(rs => rs.Name == LibraryAccountModuleTestData.FirstStreetLibraryName) is null)
        {
            dbContext.Libraries.Add(LibraryAccountModuleTestData.FirstStreetLibrary);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded Single Library Data");
        } */
    }
}
