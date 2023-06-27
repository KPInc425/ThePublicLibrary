namespace YMI.YmiInfrastructure.Data.Config;
public class ActorConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.OwnsOne(rs=>rs.Name);        
    }
}
