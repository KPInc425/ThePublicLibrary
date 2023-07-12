
namespace YmiCore.Entities;
public class Game : BaseEntityTracked<Guid>, IAggregateRoot
{
    public Player Player { get; private set; }
    public City CurrentCity { get; private set; }
    private List<LocationRegion> _regions = new();
    public IEnumerable<LocationRegion> AllRegions => _regions.AsReadOnly();
    public int RegionCount => _regions.Count(); 
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

    public Game(Player player) 
    {
        Player = Guard.Against.Null(player, "Because Player cannot be null");
        GenerateRegions(5);
        // RegionCount = AllRegions.Count();
        CityCount = AllRegions.SelectMany(r => r.RegionCities).Count();
        var citiesQuery = _regions.SelectMany(r => r.RegionCities).ToList();
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
            _regions.Add(newRegion);
        }
    }

    public void AddItemToLostItemsStorage(StorageItem storageItem)
    {
        var storageContainer = _lostItemsStorageContainers.FirstOrDefault();
        storageContainer.AddItem(storageItem);
    }
}