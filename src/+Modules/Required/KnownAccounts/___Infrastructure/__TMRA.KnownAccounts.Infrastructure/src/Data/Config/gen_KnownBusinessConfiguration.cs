// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Data.Config; 
public partial class KnownBusinessConfiguration : IEntityTypeConfiguration<KnownBusiness>
{ 
    public void Configure(EntityTypeBuilder<KnownBusiness> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        