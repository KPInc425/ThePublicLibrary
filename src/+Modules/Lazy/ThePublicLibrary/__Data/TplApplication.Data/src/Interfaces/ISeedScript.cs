namespace TplApplication.Data.Interfaces;

public interface ITplSeedScript
{
    Task PopulateTplTestData(IServiceProvider serviceProvider);
}