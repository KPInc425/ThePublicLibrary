
namespace Dpf.Core.UnitTests;

public class DirectoryConstructorTests
{
    private readonly DirectoryTestData _directoryTestData = new();

    [Fact]
    public void DirectoryConstructorTest()
    {
        // Given I have a directory
        var directory = new DpfDirectory(_directoryTestData.DirectoryCProject.Name, _directoryTestData.DirectoryCProject.FullName);

        // And I add the directory files
        foreach (var file in _directoryTestData.SubDirectoryWith3FilesDocs.DpfFiles)
        {
            directory.AddDpfFile(file.Name, file.FullName, file.Extension, file.SizeInBytesOnDisk);
        }

        // Then the files are present
        directory.DpfFiles.Count().Should().Be(_directoryTestData.SubDirectoryWith3FilesDocs.DpfFiles.Count());

        // And the directory files are unique
        directory.DpfFiles.Distinct().Count().Should().Be(_directoryTestData.SubDirectoryWith3FilesDocs.DpfFiles.Count());

        // And the directory size on disk match the sum of the files
        directory.TotalSizeOnDisk.Should().Be(_directoryTestData.SubDirectoryWith3FilesDocs.DpfFiles.Sum(rs => rs.SizeInBytesOnDisk));

    }
}