namespace AccountModule.Data.Interfaces;

public interface IKnownAccountSeedScript
{
    Task PopulateAccountModuleTestData(IServiceProvider serviceProvider);
}