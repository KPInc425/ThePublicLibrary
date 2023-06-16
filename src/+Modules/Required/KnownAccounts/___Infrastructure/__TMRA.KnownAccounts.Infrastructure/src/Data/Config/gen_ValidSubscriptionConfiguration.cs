// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Data.Config; 
public partial class ValidSubscriptionConfiguration : IEntityTypeConfiguration<ValidSubscription>
{ 
    public void Configure(EntityTypeBuilder<ValidSubscription> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
    }
} 
        