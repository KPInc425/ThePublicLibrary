namespace KnownAccountsApi;
public class SeedKnownAccountsData
{
    public async Task Initialize(IServiceProvider serviceProvider, IMediator mediator)
    {
        using (
            var dbContext =
                new KnownAccountsDbContext(
                    serviceProvider
                        .GetRequiredService<DbContextOptions<KnownAccountsDbContext>>(
                            ),
                    mediator)
        )
        {
            await serviceProvider.GetRequiredService<SeedKnownAccountsDataTPLRoot>().PopulateTestData(dbContext);
        }
    }

    /* private SeedKnownAccountsDataTPL seedKnownAccountsDataTPL = new();
    private SeedKnownAccountsLandingPagesData seedKnownAccountsLandingPagesData = new();
    private SeedKnownAccountsAgileDojos seedKnownAccountsAgileDojos = new(); */
}

