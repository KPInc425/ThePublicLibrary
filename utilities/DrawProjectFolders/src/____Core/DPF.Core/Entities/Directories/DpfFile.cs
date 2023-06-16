namespace Dpf.Core.Entities;
public class DpfFile : BaseEntityTracked<long>
{
    public DpfDirectory Directory { get; } = null!;

    public string Name { get; }
    public string FullName { get; }
    public string Extension { get; }
    public long SizeInBytesOnDisk { get; }
    private DpfFile() { }
    public DpfFile(DpfDirectory directory, string name, string fullName, string extension, long sizeInBytesOnDisk)
    {
        Directory = Guard.Against.Null(directory);
        Name = Guard.Against.NullOrEmpty(name);
        FullName = Guard.Against.NullOrEmpty(fullName);
        Extension = Guard.Against.NullOrEmpty(extension);
        SizeInBytesOnDisk = Guard.Against.Null(sizeInBytesOnDisk);
    }    
}
