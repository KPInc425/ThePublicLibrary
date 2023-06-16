// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Data.Config; 
public partial class KnownUserFilterConfiguration : IEntityTypeConfiguration<KnownUserFilter>
{ 
    public void Configure(EntityTypeBuilder<KnownUserFilter> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        