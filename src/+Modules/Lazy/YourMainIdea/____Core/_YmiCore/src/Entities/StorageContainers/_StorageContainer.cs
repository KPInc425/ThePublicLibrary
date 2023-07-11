namespace YmiCore.Entities;

public class StorageContainer : BaseEntityTracked<Guid>, IAggregateRoot
{
    // public Owners Owner { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int SlotCount { get; private set; }
    private List<StorageItem> _storageItems = new();
    public IEnumerable<StorageItem> Items => _storageItems.AsReadOnly(); 

    private StorageContainer() { }

    public StorageContainer(string name, string description, int slotCount) 
    {
        Name = Guard.Against.NullOrEmpty(name, "Because Name is required");
        Description = Guard.Against.NullOrEmpty(description, "Because Description is required");
        SlotCount = Guard.Against.Null(slotCount, "Because SlotCount is required");
    }

    public void AddItem(StorageItem storageItem)
    {
        _storageItems.Add(storageItem);
    }

    public IEnumerable<StorageItem> ViewItems()
    {
        return Items;
    }
}
