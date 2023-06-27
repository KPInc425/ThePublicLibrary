namespace YMI.YmiInfrastructure.Data.Config;
public class VideoStoreConfiguration : IEntityTypeConfiguration<VideoStore>
{
    public void Configure(EntityTypeBuilder<VideoStore> builder)
    {
        builder.OwnsOne(rs=>rs.Address);
    }
}
