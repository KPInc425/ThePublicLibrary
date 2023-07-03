namespace AccountModuleApi;
public class SeedAccountModuleData
{
    public async Task Initialize(IServiceProvider serviceProvider, IMediator mediator)
    {
        using (
            var dbContext =
                new AccountModuleDbContext(
                    serviceProvider
                        .GetRequiredService<DbContextOptions<AccountModuleDbContext>>(
                            ),
                    mediator)
        )
        {
            await serviceProvider.GetRequiredService<SeedAccountModuleDataTPLRoot>().PopulateTestData(dbContext);
        }
    }

    /* private SeedAccountModuleDataTPL seedAccountModuleDataTPL = new();
    private SeedAccountModuleLandingPagesData seedAccountModuleLandingPagesData = new();
    private SeedAccountModuleAgileDojos seedAccountModuleAgileDojos = new(); */
}

