namespace Dpf.Core.Entities.TestData;
public class DirectoryTestData : ITestData
{

    public readonly DpfDirectory DirectoryCProject;
    public readonly DpfDirectory SubDirectoryWith3FilesDocs;

    public readonly List<DpfDirectory> AllDirectories = new();

    public DirectoryTestData()
    {
        DirectoryCProject = new("CProject", @"C:\CProject");

        SubDirectoryWith3FilesDocs = new("docs", @"C:\CProject\docs");
        DirectoryCProject.AddDpfFile("DocumentA.txt", @"C:\CProject\docs", ".txt", 1024);
        DirectoryCProject.AddDpfFile("DocumentB.txt", @"C:\CProject\docs", ".txt", 2048);
        DirectoryCProject.AddDpfFile("DocumentC.txt", @"C:\CProject\docs", ".txt", 4096);

        DirectoryCProject.AddDpfFile("CProject.csproj", @"C:\CProject\CProject.csproj", ".csproj", 1024);
        DirectoryCProject.AddDpfFile("CProject.sln", @"C:\CProject\CProject.sln", ".sln", 1024);
        DirectoryCProject.AddDpfFile("README.md", @"C:\CProject\README.md", ".md", 1024);

        DirectoryCProject.AddDpfChildDirectory("bin", @"C:\CProject\bin");
        DirectoryCProject.AddDpfChildDirectory("obj", @"C:\CProject\obj");
        DirectoryCProject.AddDpfChildDirectory("src", @"C:\CProject\src");
        DirectoryCProject.AddDpfChildDirectory("test", @"C:\CProject\test");

        DirectoryCProject.AddDpfChildDirectory("logs", @"C:\CProject\logs");
        DirectoryCProject.AddDpfFile("LogA.txt", @"C:\CProject\logs", ".txt", 3222);
        DirectoryCProject.AddDpfFile("LogB.txt", @"C:\CProject\logs", ".txt", 3222);
        DirectoryCProject.AddDpfFile("LogC.txt", @"C:\CProject\logs", ".txt", 3222);

        DirectoryCProject.AddDpfChildDirectory("packages", @"C:\CProject\packages");
        DirectoryCProject.AddDpfFile("PackageA.txt", @"C:\CProject\packages", ".txt", 4565);
        DirectoryCProject.AddDpfFile("PackageB.txt", @"C:\CProject\packages", ".txt", 1446);
        DirectoryCProject.AddDpfFile("PackageC.txt", @"C:\CProject\packages", ".txt", 1212);

        DirectoryCProject.AddDpfChildDirectory("tools", @"C:\CProject\tools");

        AllDirectories.Add(DirectoryCProject);
    }
}
