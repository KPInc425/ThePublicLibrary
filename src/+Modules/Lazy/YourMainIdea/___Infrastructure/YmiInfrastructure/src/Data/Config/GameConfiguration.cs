namespace YmiInfrastructure.Data.Config;
public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
       builder.HasMany(rs => rs.LocationRegions);
       builder.HasMany(rs => rs.LostItemsStorageContainers);
    }
}
