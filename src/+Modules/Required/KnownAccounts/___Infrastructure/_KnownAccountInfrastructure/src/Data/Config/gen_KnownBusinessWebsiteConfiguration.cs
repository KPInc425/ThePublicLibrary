// ag=no
namespace KnownAccountsInfrastructure.Data.Config;
public partial class KnownBusinessWebsiteConfiguration : IEntityTypeConfiguration<KnownBusinessWebsite>
{
    public void Configure(EntityTypeBuilder<KnownBusinessWebsite> builder)
    {
        builder
            .HasOne(rs => rs.KnownBusinessWebsiteProfile)
            .WithOne(rs => rs.KnownBusinessWebsite)
            .HasForeignKey<KnownBusinessWebsiteProfile>(rs => rs.KnownBusinessWebsiteId)
            ;
    }
}
