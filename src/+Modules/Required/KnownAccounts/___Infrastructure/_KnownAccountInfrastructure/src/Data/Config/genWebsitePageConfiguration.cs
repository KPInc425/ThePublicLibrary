// ag=yes
namespace KnownAccountsInfrastructure.Data.Config; 
public partial class WebsitePageConfiguration : IEntityTypeConfiguration<WebsitePage>
{ 
    public void Configure(EntityTypeBuilder<WebsitePage> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        