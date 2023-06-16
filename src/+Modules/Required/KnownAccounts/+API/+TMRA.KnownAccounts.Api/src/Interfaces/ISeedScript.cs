namespace TPL.KnowAccounts.Api.Interfaces;
public interface ISeedScript
{
    Task Initialize(IServiceProvider serviceProvider, IMediator mediator);
    Task PopulateTestData(KnownAccountsDbContext dbContext);
}
