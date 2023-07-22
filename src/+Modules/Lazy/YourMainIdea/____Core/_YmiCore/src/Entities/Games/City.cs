namespace YmiCore.Entities;

public class City: BaseEntity<Guid>
{
    public Guid LocationRegionId { get; private set; }
    public LocationRegion LocationRegion { get; private set; }
    public string Name { get; private set; }
    // public string Description { get; private set; }
    // public string  AverageQuality { get; private set; }
    // public string AveragePrice { get; private set; }
    // public int AverageQuantity { get; private set; }
    // public string AuthorityPresence { get; private set; }
    // public Boss LocalBoss { get; private set; }
    // public Merchant LocalDealer { get; private set; }
    // public Region Region { get; private set; }

    private City() {}

    public City(LocationRegion region, string name)
    {
        LocationRegion = Guard.Against.Null(region, "Because region cannot be empty");
        Name = Guard.Against.NullOrWhiteSpace(name, "Because name cannot be empty");
    }

}
