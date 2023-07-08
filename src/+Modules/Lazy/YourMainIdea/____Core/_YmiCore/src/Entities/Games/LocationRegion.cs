namespace YmiCore.Entities;

public class LocationRegion : BaseEntity<Guid>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string ControllingFaction { get; private set;}
    private List<City> _regionCities = new();
    public IEnumerable<City> RegionCities => _regionCities.AsReadOnly();

    public LocationRegion(string name, string description = "A wonderful place to make some money.", string controllingFaction = "Free-For-All") 
    {
        Name = Guard.Against.NullOrEmpty(name, "Because name cannot be empty");
        Description = Guard.Against.NullOrEmpty(description, "Because description cannot be empty");
        ControllingFaction = Guard.Against.NullOrEmpty(controllingFaction, "Because controlling faction cannot be empty");
    }

    public void GenerateCities(LocationRegion region, int cityCount)
    {
        for (int i = 0; i < cityCount; i++)
        {
            var newCity = new City(region, $"City{i}");
            _regionCities.Add(newCity);
        }
    }
}
