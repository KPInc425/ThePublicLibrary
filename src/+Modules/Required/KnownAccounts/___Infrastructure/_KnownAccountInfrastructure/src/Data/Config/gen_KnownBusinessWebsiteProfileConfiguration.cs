// ag=yes
namespace KnownAccountsInfrastructure.Data.Config; 
public partial class KnownBusinessWebsiteProfileConfiguration : IEntityTypeConfiguration<KnownBusinessWebsiteProfile>
{ 
    public void Configure(EntityTypeBuilder<KnownBusinessWebsiteProfile> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        