namespace YmiInfrastructure.Data.Config;
public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        // Ignore the CurrentCity property in the database mapping
        builder.Ignore(g => g.CurrentCity);

        // Configure the one-to-many relationship between Game and City
        builder.HasOne(g => g.CurrentCity)
               .WithMany()
               .HasForeignKey(g => g.CurrentCityId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
