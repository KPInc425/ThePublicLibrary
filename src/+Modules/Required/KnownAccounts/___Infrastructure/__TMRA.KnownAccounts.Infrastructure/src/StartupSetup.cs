namespace TPL.KnownAccounts.Infrastructure
{
    public static class StartupSetup
	{
		public static void AddDbContext(this IServiceCollection services, string connectionString) =>
			services.AddDbContext<KnownAccountsDbContext>(options =>
				options.UseSqlServer(connectionString, b => b.MigrationsAssembly("TPL.KnownAccounts.Api"))); // will be created in web project root
	}
}
