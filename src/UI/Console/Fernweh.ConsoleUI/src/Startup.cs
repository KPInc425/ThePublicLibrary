namespace Fernweh.ConsoleUI;
using System.Reflection;
public class Startup
{
    public AutofacServiceProvider ServiceProvider { get; set; }
    public Startup()
    {
        IServiceCollection services = new ServiceCollection();
        string environment = "development";
        IConfigurationRoot configuration =
            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",
                optional: false,
                reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        bool useSqlite = configuration.GetValue<bool>(nameof(useSqlite));

       

        // ThePublicLibrary
        string tplConnectionString =
            configuration.GetConnectionString("ActiveTpl") ?? "";

        var appSettings = configuration.Get<AppSettings>();

        services
            .AddSingleton<AppSettings>(appSettings!);

        services
            .AddTplDbContext(tplConnectionString);

        services.AddSingleton<ITplDataService, TplDirectDataService>();
        // \ThePublicLibrary

        services.AddLogging().BuildServiceProvider();

        services.AddSingleton<App>();

        
        var containerBuilder = new ContainerBuilder();
        containerBuilder.Populate(services);

        //containerBuilder.RegisterModule(new SpyderFootScansCoreModule());
        //containerBuilder.RegisterModule(new SpyderFootScansInfrastructureModule(true));

        //containerBuilder.RegisterModule(new ScanModulesCoreModule());
        //containerBuilder.RegisterModule(new ScanModulesInfrastructureModule(true));


        var container = containerBuilder;
        var isInDevelopment = true; //_env.EnvironmentName == "Development";
        container.RegisterModule(new TplCoreModule());
        container.RegisterModule(new TplInfrastructureModule(isInDevelopment));
        container.RegisterModule(new TplApplicationModule(isInDevelopment));
        container.RegisterModule(new FernwehConsoleModule(isInDevelopment, typeof(App).GetTypeInfo().Assembly));
        var builtContainer = container.Build();
        ServiceProvider = new AutofacServiceProvider(builtContainer);
    }

    /* public void ConfigureContainer(ContainerBuilder builder)
    {
        var isInDevelopment = true; //_env.EnvironmentName == "Development";
        builder.RegisterModule(new TplCoreModule());
        builder.RegisterModule(new TplInfrastructureModule(isInDevelopment));
        builder.RegisterModule(new TplApplicationModule(isInDevelopment));
        builder.RegisterModule(new FernwehConsoleModule(isInDevelopment, typeof(App).GetTypeInfo().Assembly));
    } */
}
