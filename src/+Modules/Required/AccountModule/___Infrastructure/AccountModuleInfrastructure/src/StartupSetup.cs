namespace AccountModuleInfrastructure
{
	public static class StartupSetup
	{
		/* 		services.AddDbContext<AccountModuleDbContext>(options =>
					options.UseSqlServer(connectionString, b => b.MigrationsAssembly("AccountModuleApplication.Data"))); // will be created in web project root */

		public static void AddKnownAccountDbContext(this IServiceCollection services, string connectionString) =>
			services.AddDbContext<AccountModuleDbContext>(options =>
				options.UseSqlite(connectionString, b => b.MigrationsAssembly("AccountModuleApplication.Data")));

		public static void AddKnownAccountInMemoryDbContext(this IServiceCollection services, string dbName) =>

			services.AddDbContext<AccountModuleDbContext>(options =>
				options.UseInMemoryDatabase(dbName));
	}
}
