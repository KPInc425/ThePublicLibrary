// ag=yes
namespace KnownAccountsInfrastructure.Data.Config; 
public partial class KnownUserConfiguration : IEntityTypeConfiguration<KnownUser>
{ 
    public void Configure(EntityTypeBuilder<KnownUser> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        