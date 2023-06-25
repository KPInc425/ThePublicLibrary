namespace TPL.TplInfrastructure.Data;
public class TplDbContext : DbContext
{
    private readonly IMediator _mediator;
    public TplDbContext(DbContextOptions<TplDbContext> options, IMediator mediator)
        : base(options)
    {
        _mediator = mediator;
    }

    public DbSet<Member> Members { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<Library> Libraries { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCopy> BookCopies { get; set; }
    public DbSet<Author> Authors { get; set; }
    
    // Shared
    public DbSet<BookCategory> BookCategories { get; set; }    
    public DbSet<MemberInMembership> MemberInMemberships { get; set; }


    // Value Objects
    //public DbSet<IsbnVO> Isbns { get; set; }
    //public DbSet<DigitalAddressVO> DigitalAddresses { get; set; }
    //public DbSet<NameVO> Names { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.BuildIndexesFromAnnotations();
        modelBuilder.BuildIndexesFromAnnotationsForSqlServer();
        modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();

        //this.ChangeTracker.LazyLoadingEnabled = true;

        // alternately this is built-in to EF Core 2.2
        //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
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
                await _mediator.Publish(domainEvent).ConfigureAwait(false);
            }
        }

        return result;
    }

    public override int SaveChanges()
    {
        return SaveChangesAsync().GetAwaiter().GetResult();
    }
}