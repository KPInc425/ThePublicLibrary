namespace Dpf.Infrastructure.IntegrationTests.Data.Directories;
public class EfDirectoriesRepositoryAdd : BaseTestFixture
{
    [Fact]
    public async Task AddsDirectorySetsId()
    {
        var repository = DirectoryRepository();
        var directory = _directoryTestData.DirectoryCProject;

        await repository.AddAsync(directory);

        var newDirectory = (await repository.ListAsync())
                        .FirstOrDefault();

        Assert.NotNull(newDirectory?.Id);
    }
}
