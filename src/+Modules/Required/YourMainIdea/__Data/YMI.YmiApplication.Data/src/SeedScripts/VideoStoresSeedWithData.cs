namespace YMI.YmiApplication.Data.SeedScripts;
public class VideoStoresSeedWithData : IYmiSeedScript
{
    public async Task PopulateYmiTestData(IServiceProvider serviceProvider)
    {
        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<VideosSeedWithData>>();

        using var dbContext =
                new YmiDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<YmiDbContext>>(
                        ), mediator);

       
        if (!dbContext.VideoStores.Any())
        {
            dbContext.VideoStores.AddRange(VideoStoreYmiTestData.AllVideoStores);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded All VideoStore Data");
        }

        if (dbContext.VideoStores.FirstOrDefault(rs => rs.Name == VideoStoreYmiTestData.FirstStreetVideoStoreName) is null)
        {
            dbContext.VideoStores.Add(VideoStoreYmiTestData.FirstStreetVideoStore);
            await dbContext.SaveChangesAsync();
            logger?.LogInformation("Seeded Single VideoStore Data");
        }
    }
}
