
namespace YmiCore.Entities;
public class Game : BaseEntityTracked<Guid>, IAggregateRoot
{
    public Player Player { get; private set; }
    public City CurrentCity { get; private set; }
    private List<LocationRegion> _regions = new();
    public IEnumerable<LocationRegion> AllRegions => _regions.AsReadOnly();
    public string CurrentDay { get; private set; }
    public int MaxDays { get; private set; }
    public string TimeOfDay { get; private set; }
    public string StartLocation { get; private set; }
    public int DifficultyLevel { get; private set; }
    public int RegionCount { get; private set; }
    public int CityCount { get; private set; }
    public int Luck { get; private set; }

    private Game() {}

    public Game(Player player) 
    {
        Player = Guard.Against.Null(player, "Because Player cannot be null");
        GenerateRegions(5);
        var citiesQuery = _regions.SelectMany(r => r.RegionCities).ToList();
        CurrentCity = citiesQuery[new Random().Next(0, citiesQuery.Count)];
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
}