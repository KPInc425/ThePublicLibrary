namespace TPL.TplInfrastructure.Data.Config;
public class LibraryConfiguration : IEntityTypeConfiguration<Library>
{
    public void Configure(EntityTypeBuilder<Library> builder)
    {
        builder.OwnsOne(rs=>rs.Address);
    }
}