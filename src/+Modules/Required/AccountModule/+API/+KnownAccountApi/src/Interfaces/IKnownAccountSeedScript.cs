namespace AccountModule.KnowAccounts.Api.Interfaces;
public interface IKnownAccountSeedScript
{
    Task Initialize(IServiceProvider serviceProvider, IMediator mediator);
    Task PopulateTestData(AccountModuleDbContext dbContext);
}
