namespace TPL.Infrastructure;
public static class StartupSetup

{
    public static void AddTplPrimaryDbContext(this IServiceCollection services, string connectionString) =>

        services.AddDbContext<TplPrimaryDbContext>(options =>
            options.UseSqlite(connectionString, b => b.MigrationsAssembly("TPL.Application.Data")));

    public static void AddTplPrimaryInMemoryDbContext(this IServiceCollection services, string dbName) =>

        services.AddDbContext<TplPrimaryDbContext>(options =>
            options.UseInMemoryDatabase(dbName));
}

