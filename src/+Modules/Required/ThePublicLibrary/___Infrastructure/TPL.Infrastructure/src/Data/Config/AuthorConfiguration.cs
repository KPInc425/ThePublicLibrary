namespace TPL.Infrastructure.Data.Config;
public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.OwnsOne(rs=>rs.Name);        
    }
}