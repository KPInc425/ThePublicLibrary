// ag=yes
namespace KnownAccountsInfrastructure.Data.Config; 
public partial class KnownAccountConfiguration : IEntityTypeConfiguration<KnownAccount>
{ 
    public void Configure(EntityTypeBuilder<KnownAccount> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        