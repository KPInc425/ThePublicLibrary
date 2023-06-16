// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Data.Config; 
public partial class KnownFilterConfiguration : IEntityTypeConfiguration<KnownFilter>
{ 
    public void Configure(EntityTypeBuilder<KnownFilter> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        