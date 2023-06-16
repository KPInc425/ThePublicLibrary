// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Data.Config; 
public partial class KnownBusinessWebsiteAliasConfiguration : IEntityTypeConfiguration<KnownBusinessWebsiteAlias>
{ 
    public void Configure(EntityTypeBuilder<KnownBusinessWebsiteAlias> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        