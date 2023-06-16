namespace Dpf.Core.Entities;
public class DpfDirectory : BaseEntityTracked<long>, IAggregateRoot
{
    public DpfDirectory? Parent { get; set; }
    public string Name { get; private set; }
    public string FullName { get; private set; }

    public int? FileCount { get; private set; } = 0;
    public long? TotalSizeOnDisk { get; private set; } = 0;


    private readonly List<DpfFile> _dpfFiles = new();
    public IEnumerable<DpfFile> DpfFiles => _dpfFiles.AsReadOnly();

    private readonly List<DpfDirectory> _children = new();
    public IEnumerable<DpfDirectory> Children => _children.AsReadOnly();

    private DpfDirectory() { }

    public DpfDirectory(string name, string fullName)
    {
        Name = name;
        FullName = fullName;
    }

    public void AddDpfFile(string name, string fullName, string extension, long sizeInBytesOnDisk)
    {
        var dpfFile = new DpfFile(this, name, fullName, extension, sizeInBytesOnDisk);
        if(!_dpfFiles.Any(rs=>rs.FullName == fullName)) {
            _dpfFiles.Add(dpfFile);
            FileCount++;
            TotalSizeOnDisk += sizeInBytesOnDisk;
        }
    }

    public void AddDpfChildDirectory(string name, string fullName)
    {
        var dpfDirectory = new DpfDirectory(name, fullName);
        if(!_children.Any(rs=>rs.FullName == fullName)) {
            _children.Add(dpfDirectory);
        }
    }

    public override string ToString()
    {
        return $"{Name} ({FileCount})";
    }
}
