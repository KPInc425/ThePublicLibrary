namespace AccountModuleApi;

public static class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;

            var context = services.GetRequiredService<AccountModuleDbContext>();
            /* context.Database.EnsureCreated();
            //context.Database.Migrate();

            var seedAccountModuleData = services.GetRequiredService<SeedAccountModuleData>();
            var mediator = services.GetRequiredService<IMediator>();
            seedAccountModuleData.Initialize(services, mediator).GetAwaiter().GetResult();
 */
        }

        host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder
                    .UseStartup<Startup>()
                    .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                    // logging.AddAzureWebAppDiagnostics(); add this if deploying to Azure
                });
            });
}