namespace YmiInfrastructure.Data;
public class YmiDbContext : DbContext
{
    private readonly IMediator _mediator;
    public YmiDbContext(DbContextOptions<YmiDbContext> options, IMediator mediator)
        : base(options)
    {
        _mediator = mediator;
    }

    public DbSet<Game> Games { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<LocationRegion> LocationRegions { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<StorageContainer> StorageContainers { get; set; }
    public DbSet<StorageItem> StorageItems { get; set; }


    // Shared

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.BuildIndexesFromAnnotations();
        modelBuilder.BuildIndexesFromAnnotationsForSqlServer();
        modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();
        //this.ChangeTracker.LazyLoadingEnabled = true;
    }
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entityEntry in ChangeTracker
            .Entries()
            .Where(E => (E.State == EntityState.Added
                || E.State == EntityState.Modified)
                && E.GetType().Name.EndsWith("VO") )
            .ToList())
        {
            if (entityEntry.State == EntityState.Modified)
            {
                entityEntry.Property("UpdatedOn").CurrentValue = DateTime.Now;
            }
            else if (entityEntry.State == EntityState.Added)
            {
                entityEntry.Property("CreatedOn").CurrentValue = DateTime.Now;
                entityEntry.Property("UpdatedOn").CurrentValue = DateTime.Now;
            }
        }

        int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        // ignore events if no dispatcher provided
        if (_mediator == null) return result;

        // dispatch events only if save was successful
        var entitiesWithEvents = ChangeTracker.Entries<BaseEntity<System.Guid>>()
            .Select(e => e.Entity)
            .Where(e => e.Events.Any())
            .ToArray();

        foreach (var entity in entitiesWithEvents)
        {
            var events = entity.Events.ToArray();
            entity.Events.Clear();
            foreach (var domainEvent in events)
            {
                await _mediator.Publish(domainEvent, cancellationToken).ConfigureAwait(false);
            }
        }

        return result;
    }

    public override int SaveChanges()
    {
        return SaveChangesAsync().GetAwaiter().GetResult();
    }
}