namespace TPL.Infrastructure.Data.Config;
public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.OwnsOne(rs=>rs.Isbn);
        
    }
}
