// ag=yes
namespace KnownAccountsInfrastructure.Data.Config; 
public partial class WebsitePageContentConfiguration : IEntityTypeConfiguration<WebsitePageContent>
{ 
    public void Configure(EntityTypeBuilder<WebsitePageContent> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        