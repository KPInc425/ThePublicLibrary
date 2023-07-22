namespace YmiInfrastructure.Data.Config;
public class LocationRegionConfiguration : IEntityTypeConfiguration<LocationRegion>
{
    public void Configure(EntityTypeBuilder<LocationRegion> builder)
    {
    //    builder.HasMany(rs => rs.Cities).WithOne(rs => rs.LocationRegion).HasForeignKey(rs => rs.Id);
    }
}
