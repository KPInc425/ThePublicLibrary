namespace Dpf.Infrastructure;
public static class StartupSetup

{
    public static void AddDpfPrimaryDbContext(this IServiceCollection services, string connectionString) =>

        services.AddDbContext<DpfPrimaryDbContext>(options =>
            options.UseSqlite(connectionString, b => b.MigrationsAssembly("DPF.Application.Data")));

    public static void AddDpfPrimaryInMemoryDbContext(this IServiceCollection services, string dbName) =>

        services.AddDbContext<DpfPrimaryDbContext>(options =>
            options.UseInMemoryDatabase(dbName));
}

