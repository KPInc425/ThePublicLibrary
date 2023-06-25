namespace TPL.TplInfrastructure;
public static class StartupSetup

{
    public static void AddTplDbContext(this IServiceCollection services, string connectionString) =>

        services.AddDbContext<TplDbContext>(options =>
            options.UseSqlite(connectionString, b => b.MigrationsAssembly("TPL.TplApplication.Data")));

    public static void AddTplInMemoryDbContext(this IServiceCollection services, string dbName) =>

        services.AddDbContext<TplDbContext>(options =>
            options.UseInMemoryDatabase(dbName));
}

