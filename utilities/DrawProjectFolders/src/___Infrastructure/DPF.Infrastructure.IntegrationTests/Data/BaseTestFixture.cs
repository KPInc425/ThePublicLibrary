namespace Dpf.Infrastructure.IntegrationTests.Data;
public abstract class BaseTestFixture
{
    protected DpfPrimaryDbContext _dbContext;
    protected readonly static DirectoryTestData _directoryTestData = new();
    
    protected static DbContextOptions<DpfPrimaryDbContext> CreateNewContextOptions()
    {
        // Create a fresh service provider, and therefore a fresh
        // InMemory database instance.
        var serviceProvider = new ServiceCollection()
            .AddEntityFrameworkInMemoryDatabase()
            .BuildServiceProvider();

        // Create a new options instance telling the context to use an
        // InMemory database and the new service provider.
        var builder = new DbContextOptionsBuilder<DpfPrimaryDbContext>();
        builder.UseInMemoryDatabase("DpfPrimaryDb")
               .UseInternalServiceProvider(serviceProvider);

        return builder.Options;
    }

    protected EfRepository<DpfDirectory> DirectoryRepository()
    {
        var options = CreateNewContextOptions();
        var mockMediator = new Mock<IMediator>();

        _dbContext = new DpfPrimaryDbContext(options, mockMediator.Object);
        return new EfRepository<DpfDirectory>(_dbContext);
    }    
}
