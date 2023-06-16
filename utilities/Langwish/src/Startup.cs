using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Langwish.Infrastructure;
using Langwish.Services;

namespace Langwish
{
    public class Startup
    {
        public readonly IConfiguration Configuration;
        public readonly IServiceProvider Provider;
        public Startup()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            Configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddJsonFile($"appsettings.{environment}.json", optional: true)
                            .Build();        

            // instantiate
            var services = new ServiceCollection();

            // add necessary services
            services.AddTransient<DatabaseService>();
            services.AddTransient<MapFileCreateService>();
            services.AddTransient<SyncWithExcelService>();    
            services.AddTransient<WriteExcelToResx>();

            services.AddDbContext<LangwishDbContext>();

            // build the pipeline
            Provider = services.BuildServiceProvider();
        }        
    }
}
