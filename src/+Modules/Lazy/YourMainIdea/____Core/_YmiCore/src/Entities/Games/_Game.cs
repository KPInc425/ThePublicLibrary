
namespace YmiCore.Entities;
public class Game : BaseEntityTracked<Guid>, IAggregateRoot
{
    public Player Player { get; private set; }
    public Guid CurrentCityId { get; private set; }
    public City CurrentCity { get; private set; }
    private List<LocationRegion> _locationRegions = new();
    public IEnumerable<LocationRegion> LocationRegions => _locationRegions.AsReadOnly();
    public int RegionCount => _locationRegions.Count(); 
    public int CityCount { get; private set; }
    public int CurrentDay { get; private set; }
    public int MaxDays { get; private set; }
    public DayCycleTypes TimeOfDay { get; private set; }
    public string StartLocation { get; private set; }
    public int DifficultyLevel { get; private set; }
    public int PlayerLuck { get; private set; }
    private List<StorageContainer> _lostItemsStorageContainers = new();
    public IEnumerable<StorageContainer> LostItemsStorageContainers => _lostItemsStorageContainers.AsReadOnly();

    private Game() {}
    public Game(Guid id, Player player): this(player)
    {
        Id = id;
    }
    public Game(Player player) 
    {
        Player = Guard.Against.Null(player, "Because Player cannot be null");
        GenerateRegions(5);
        // RegionCount = LocationRegions.Count();
        CityCount = LocationRegions.SelectMany(r => r.Cities).Count();
        var citiesQuery = _locationRegions.SelectMany(r => r.Cities).ToList();
        CurrentCity = citiesQuery[new Random().Next(0, citiesQuery.Count)];
        CurrentDay = 1;
        MaxDays = 30;
        TimeOfDay = DayCycleTypes.Morning;
        StartLocation = CurrentCity.Name;
        DifficultyLevel = (int)Player.UpbringingType;
        PlayerLuck = new Random().Next(DifficultyLevel, 100);
        _lostItemsStorageContainers.Add(new StorageContainer("Trash Can", "What ever fits, stays.", 25));
    }

    private void GenerateRegions(int regionCount)
    {
        for (int i = 0; i < regionCount; i++)
        {
            var newRegion = new LocationRegion($"Region{i}");
            newRegion.GenerateCities(newRegion, 6);
            _locationRegions.Add(newRegion);
        }
    }

    public void AddItemToLostItemsStorage(StorageItem storageItem)
    {
        var storageContainer = _lostItemsStorageContainers.FirstOrDefault();
        storageContainer.AddItem(storageItem);
    }

    public IEnumerable<StorageItem> AddManyItemsToLostItemsStorage(IEnumerable<StorageItem> manyStorageItems)
    {
        var storageContainer = _lostItemsStorageContainers.LastOrDefault();
        if (storageContainer.StorageItems.Count() + manyStorageItems.Count() <= storageContainer.SlotCount)
        {
            foreach (var storageItem in manyStorageItems)
            {
                storageContainer.AddItem(storageItem);
            }
            return storageContainer.StorageItems;
        }
        else
        {
            while (manyStorageItems.Count() > 0)
            {
                var overFlowCount = storageContainer.StorageItems.Count() + manyStorageItems.Count() - storageContainer.SlotCount;
                var itemsThatFit = manyStorageItems.SkipLast(overFlowCount);
                manyStorageItems = manyStorageItems.SkipLast(itemsThatFit.Count());
                foreach (var storageItem in itemsThatFit)
                {
                    storageContainer.AddItem(storageItem);
                }

                if (manyStorageItems.Count() > 0)
                {
                    _lostItemsStorageContainers.Add(new StorageContainer("Lost Jacket", "What ever fits, stays.", 25));
                    storageContainer = _lostItemsStorageContainers.Last();
                }
            }
            
            return _lostItemsStorageContainers.SelectMany(r => r.StorageItems);
        }
    }

    public IEnumerable<StorageItem> ViewLostItemsInStorage()
    {
        return _lostItemsStorageContainers.SelectMany(r => r.StorageItems);

    }
}