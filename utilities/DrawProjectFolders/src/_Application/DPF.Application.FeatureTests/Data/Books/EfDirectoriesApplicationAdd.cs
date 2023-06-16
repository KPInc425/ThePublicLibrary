namespace Dpf.Application.FeatureTests.Data.Directories;
public class EfDirectoryApplicationAdd : BaseApplicationTestFixture
{
    [Fact]
    public async Task AddDirectory()
    {
        (await _dataService.DpfDirectoriesGetAllAsync(new DpfDirectoriesGetAllQuery())).Count.Should().Be(0, "because we haven't added any directories yet");
        var cmd = new DpfDirectoryAddCommand(_directoryTestData.DirectoryCProject.Name, _directoryTestData.DirectoryCProject.FullName);        
        await _dataService.DpfDirectoryAddAsync(cmd);

        var qry = new DpfDirectoriesGetAllQuery();
        var result = (await _dataService.DpfDirectoriesGetAllAsync(qry));
        result.Count().Should().Be(1, "because we added a single directory");


        result.First().Name.Should().Be(_directoryTestData.DirectoryCProject.Name);
        result.First().FullName.Should().Be(_directoryTestData.DirectoryCProject.FullName);
        result.First().FileCount.Should().Be(_directoryTestData.DirectoryCProject.FileCount);

    }
}
