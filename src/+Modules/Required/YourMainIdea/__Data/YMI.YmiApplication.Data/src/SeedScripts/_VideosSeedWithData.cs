namespace YMI.YmiApplication.Data.SeedScripts;
public class VideosSeedWithData : IYmiSeedScript
{
    public async Task PopulateYmiTestData(IServiceProvider serviceProvider)
    {
        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<VideosSeedWithData>>();
        using var dbContext =
                new YmiDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<YmiDbContext>>(
                        ), mediator);
        
        foreach (var video in VideoYmiTestData.AllVideos)
        {
            if (!dbContext.Videos.AsEnumerable().Any(rs => video.Isbn.Equals(rs.Isbn)))
            {
                dbContext.Videos.Add(video);
                logger?.LogInformation("{video.Title} was created in the database.", video.Title);
            }
            else
            {
                logger?.LogInformation("{video.Title} already exist in the database.", video.Title);
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
