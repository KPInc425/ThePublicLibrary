namespace Dpf.Application.Data.SeedScripts;
public class DirectoriesSeedWithData : ISeedScript
{
    public async Task PopulateTestData(IServiceProvider serviceProvider)
    {
        var directoryTestData = new DirectoryTestData();
        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<DirectoriesSeedWithData>>();
        using var dbContext =
                new DpfPrimaryDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<DpfPrimaryDbContext>>(
                        ), mediator);
        if (directoryTestData is null)
        {
            throw new NullReferenceException("Directory Test Data is null");
        }
        else
        {
            logger?.LogInformation("Directory Test data is available");
        }
        foreach (var directory in directoryTestData.AllDirectories)
        {
            if (dbContext.DpfDirectories.FirstOrDefault(rs => rs.Name == directory.Name) is null)
            {
                dbContext.DpfDirectories.Add(directory);
                logger?.LogInformation("{directory.Name} was created in the database.", directory.Name);
            }
            else
            {
                logger?.LogInformation("{directory.Name} already exist in the database.", directory.Name);
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
