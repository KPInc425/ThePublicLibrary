// ag=yes
namespace KnownAccountsInfrastructure.Data.Config; 
public partial class KnownFilterCategoryConfiguration : IEntityTypeConfiguration<KnownFilterCategory>
{ 
    public void Configure(EntityTypeBuilder<KnownFilterCategory> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        