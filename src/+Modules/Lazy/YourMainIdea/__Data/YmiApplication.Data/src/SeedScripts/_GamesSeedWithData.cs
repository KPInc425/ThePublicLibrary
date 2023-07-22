namespace YmiApplication.Data.SeedScripts;
public class GamesSeedWithData : IYmiSeedScript
{
    public async Task PopulateYmiTestData(IServiceProvider serviceProvider)
    {
        var mediator = serviceProvider.GetRequiredService<IMediator>();
        var logger = serviceProvider.GetRequiredService<ILogger<GamesSeedWithData>>();
        using var dbContext =
                new YmiDbContext(serviceProvider
                        .GetRequiredService<DbContextOptions<YmiDbContext>>(
                        ), mediator);
        
        foreach (var game in GameTestData.AllGames)
        {
            if (!dbContext.Games.AsEnumerable().Any(rs => game.Id == rs.Id))
            {
                dbContext.Games.Add(game);
                logger?.LogInformation("{game.Id} was created in the database.", game.Id);
            }
            else
            {
                logger?.LogInformation("{game.Id} already exist in the database.", game.Id);
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
