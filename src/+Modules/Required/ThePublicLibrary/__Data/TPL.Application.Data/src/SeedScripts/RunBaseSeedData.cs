using System.Reflection;

namespace TPL.Application.Data.SeedScripts;
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
            .Where(x => x.IsAssignableTo(typeof(ISeedScript)) && x.IsClass)
            .OrderBy(rs => rs.Name))
        {
            _logger.LogInformation("Seeding ... {seedData.Name}", seedData.Name);
            await ((ISeedScript)serviceProvider
                .GetRequiredService(seedData))
                .PopulateTestData(serviceProvider);
        }
    }
}
