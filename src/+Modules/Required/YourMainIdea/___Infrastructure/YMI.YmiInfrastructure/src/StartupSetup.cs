namespace YMI.YmiInfrastructure;
public static class StartupSetup

{
    public static void AddYmiDbContext(this IServiceCollection services, string connectionString) =>

        services.AddDbContext<YmiDbContext>(options =>
            options.UseSqlite(connectionString, b => b.MigrationsAssembly("YMI.YmiApplication.Data")));

    public static void AddYmiInMemoryDbContext(this IServiceCollection services, string dbName) =>

        services.AddDbContext<YmiDbContext>(options =>
            options.UseInMemoryDatabase(dbName));
}

