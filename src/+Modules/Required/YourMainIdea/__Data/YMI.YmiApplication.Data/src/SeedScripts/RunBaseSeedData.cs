using System.Reflection;

namespace YMI.YmiApplication.Data.SeedScripts;
public class RunBaseSeedData
{
    private IMediator? _mediator;
    private ILogger<RunBaseSeedData>? _logger;
    public async Task Initialize(IServiceProvider serviceProvider)
    {
        _mediator = serviceProvider.GetRequiredService<IMediator>();
        _logger = serviceProvider.GetRequiredService<ILogger<RunBaseSeedData>>();
        
        var videosSeedWithData = new VideosSeedWithData().PopulateYmiTestData(serviceProvider);
        
        /* foreach (var seedData in Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.IsClass && x.IsAbstract && x.IsSealed)
            .OrderBy(rs => rs.Name))
        {
            _logger.LogInformation("Seeding ... {seedData.Name}", seedData.Name);
            await ((IYmiSeedScript)serviceProvider
                .GetRequiredService(seedData))
                .PopulateYmiTestData(serviceProvider);
        } */
    }
}
