using System.Reflection;

namespace TplApplication.Data.SeedScripts;
public class RunBaseSeedData
{
    private IMediator? _mediator;
    private ILogger<RunBaseSeedData>? _logger;
    public async Task Initialize(IServiceProvider serviceProvider)
    {
        _mediator = serviceProvider.GetRequiredService<IMediator>();
        _logger = serviceProvider.GetRequiredService<ILogger<RunBaseSeedData>>();
        
        foreach (var seedData in Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.IsClass && x.IsAbstract && x.IsSealed && x.Name.Contains("SeedWithData") && !x.Name.Contains("RunBase"))
            .OrderBy(rs => rs.Name))
        {
            _logger.LogInformation("Seeding ... {seedData.Name}", seedData.Name);
            await ((ITplSeedScript)serviceProvider
                .GetRequiredService(seedData))
                .PopulateTplTestData(serviceProvider);
        }
    }
}
