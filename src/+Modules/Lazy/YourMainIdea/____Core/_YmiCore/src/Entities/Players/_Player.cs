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
        return storageContainer.Items;
    }

    public void AddItemToStorage(StorageItem storageItem)
    {
        var storageContainer = _storageContainers.FirstOrDefault();
        storageContainer.AddItem(storageItem);
    }

    public IEnumerable<StorageItem> AddManyItemsToStorage(IEnumerable<StorageItem> manyStorageItems)
    {
        var storageContainer = _storageContainers.FirstOrDefault();
        if (storageContainer.Items.Count() + manyStorageItems.Count() <= storageContainer.SlotCount)
        {
            foreach (var storageItem in manyStorageItems)
            {
                storageContainer.AddItem(storageItem);
            }
            return storageContainer.Items;
        }
        else
        {
            var overFlowCount = storageContainer.Items.Count() + manyStorageItems.Count() - storageContainer.SlotCount;
            var itemsThatFit = manyStorageItems.SkipLast(overFlowCount);
            foreach (var storageItem in itemsThatFit)
            {
                storageContainer.AddItem(storageItem);
            }
            return manyStorageItems.TakeLast(overFlowCount);
        }
    }
    public bool RemoveItemFromStorage(StorageItem storageItem)
    {
        
        var storageContainer = _storageContainers.FirstOrDefault();
        if (storageContainer.Items.Contains(storageItem))
        {
            return storageContainer.RemoveItem(storageItem);
        }
        return false;
    }
    public bool RemoveManyItemsFromStorage(IEnumerable<StorageItem> manyStorageItems)
    {
        var storageContainer = _storageContainers.FirstOrDefault();
        var storedItemCount = storageContainer.Items.Where(x => x.Name == manyStorageItems.FirstOrDefault().Name).Count();
        if (storedItemCount >= manyStorageItems.Count())
        {
            foreach (var storageItem in manyStorageItems)
            {
                storageContainer.RemoveItem(storageItem);
            }
            return true;
        }
        else 
        {
            return false;
        }
    }





    public override string ToString()
    {
        return Name.ToString();
    }
}
