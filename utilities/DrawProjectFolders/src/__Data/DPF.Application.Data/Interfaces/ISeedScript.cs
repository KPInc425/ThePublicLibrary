namespace Dpf.Application.Data.Interfaces;

public interface ISeedScript
{
    Task PopulateTestData(IServiceProvider serviceProvider);
}