namespace YMI.YmiInfrastructure.Data.Config;
public class VideoConfiguration : IEntityTypeConfiguration<Video>
{
    public void Configure(EntityTypeBuilder<Video> builder)
    {
        builder.OwnsOne(rs => rs.Isbn, rs =>
            {
                rs.WithOwner();                
            });        
    }
}
