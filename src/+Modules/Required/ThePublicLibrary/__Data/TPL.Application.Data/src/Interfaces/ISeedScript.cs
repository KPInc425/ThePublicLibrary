namespace TPL.Application.Data.Interfaces;

public interface ISeedScript
{
    Task PopulateTestData(IServiceProvider serviceProvider);
}