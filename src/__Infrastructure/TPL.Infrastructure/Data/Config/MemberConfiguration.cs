namespace TPL.Infrastructure.Data.Config;
public class MemberConfigurationConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.OwnsOne(rs=>rs.Address);
        builder.OwnsOne(rs=>rs.Phone);
        builder.OwnsOne(rs=>rs.Email);
    }
}
