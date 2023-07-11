namespace YmiCore.Entities;
public class Player : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Bio { get; private set; }
    public UpbringingTypes UpbringingType { get; private set; }
    private List<StorageContainer> _storageContainers = new();
    public IEnumerable<StorageContainer> StorageContainers => _storageContainers.AsReadOnly();


    private Player() { }
    public Player(string name, string description = "The most B-E-A-utiful!", string bio = "This person bio\'s!", UpbringingTypes upbringingType = UpbringingTypes.SuburbanKid)
    {
        Name = Guard.Against.NullOrEmpty(name, "Because Name cannot be empty");
        Description = description;
        Bio = bio;
        UpbringingType = upbringingType;
        _storageContainers.Add(new StorageContainer("Pockets", "What ever fits, stays.", 100));
    }

    public void AddStorageContainer(StorageContainer storageContainer)
    {
        _storageContainers.Add(storageContainer);
    }

    public void RemoveStorageContainer(StorageContainer storageContainer)
    {
        _storageContainers.Remove(storageContainer);
    }

    public IEnumerable<StorageItem> ViewItemsInStorage()
    {
        var storageContainer = _storageContainers.FirstOrDefault();
        return storageContainer.ViewItems();
    }

    public void AddItemToStorage(StorageItem storageItem)
    {
        var storageContainer = _storageContainers.FirstOrDefault();
        storageContainer.AddItem(storageItem);
    }

    public void AddManyItemsToStorage(IEnumerable<StorageItem> manyStorageItems)
    {
        var storageContainer = _storageContainers.FirstOrDefault();
        foreach (var storageItem in manyStorageItems)
        {
            storageContainer.AddItem(storageItem);
        }
    }


    public override string ToString()
    {
        return Name.ToString();
    }
}
