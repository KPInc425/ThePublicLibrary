namespace TPL.Infrastructure.IntegrationTests.Data;
public abstract class BaseTestFixture
{
    protected TplPrimaryDbContext _dbContext;
    
    protected static DbContextOptions<TplPrimaryDbContext> CreateNewContextOptions()
    {
        // Create a fresh service provider, and therefore a fresh
        // InMemory database instance.
        var serviceProvider = new ServiceCollection()
            .AddEntityFrameworkInMemoryDatabase()
            .BuildServiceProvider();

        // Create a new options instance telling the context to use an
        // InMemory database and the new service provider.
        var builder = new DbContextOptionsBuilder<TplPrimaryDbContext>();
        builder.UseInMemoryDatabase("TplPrimaryDb")
               .UseInternalServiceProvider(serviceProvider);

        return builder.Options;
    }

    protected EfRepository<Library> LibraryRepository()
    {
        var options = CreateNewContextOptions();
        var mockMediator = new Mock<IMediator>();

        _dbContext = new TplPrimaryDbContext(options, mockMediator.Object);
        return new EfRepository<Library>(_dbContext);
    }

    protected EfRepository<Book> BookRepository()
    {
        var options = CreateNewContextOptions();
        var mockMediator = new Mock<IMediator>();

        _dbContext = new TplPrimaryDbContext(options, mockMediator.Object);
        return new EfRepository<Book>(_dbContext);
    }

    protected EfRepository<Member> MemberRepository()
    {
        var options = CreateNewContextOptions();
        var mockMediator = new Mock<IMediator>();

        _dbContext = new TplPrimaryDbContext(options, mockMediator.Object);
        return new EfRepository<Member>(_dbContext);
    }

    protected EfRepository<Membership> MembershipRepository()
    {
        var options = CreateNewContextOptions();
        var mockMediator = new Mock<IMediator>();

        _dbContext = new TplPrimaryDbContext(options, mockMediator.Object);
        return new EfRepository<Membership>(_dbContext);
    }
}
