namespace KnownAccountsApi;
public class Startup
{
    private readonly IWebHostEnvironment _env;
    public Startup(IConfiguration config, IWebHostEnvironment env)
    {
        Configuration = config;
        _env = env;
    }
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {

        
        
        services
            .Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
        // default to TPLKnownAccountsConnectionString ENVVAR
        string connectionString =
            Configuration.GetConnectionString("DefaultConnection"); //Configuration.GetConnectionString("DefaultConnection");
        var appSettings = Configuration.Get<AppSettings>();
        services.AddSingleton<AppSettings>(appSettings);
        services.AddAutoMapper(typeof(KnownAccountMap).GetTypeInfo().Assembly);
        services.AddSingleton<SeedKnownAccountsData>();
        // our goal is to discover all of the ISeedScripts and load them up here.
        /* services.AddSingleton<SeedKnownAccountsLandingPagesData>();
        services.AddSingleton<SeedKnownAccountsAgileDojos>();
        services.AddSingleton<SeedKnownAccountsDataTPLRoot>();
        services.AddSingleton<SeedKnownAccountsDataTPLClients>();
        services.AddSingleton<SeedKnownAccountsBBQGeorge>();
        services.AddSingleton<SeedKnownAccountsWestCoastFire>(); */
        services.AddDbContext(connectionString);
        services.AddHttpContextAccessor();
        /* services
            .AddControllersWithViews()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler =  ReferenceHandler.Preserve;
            });
        services.AddRazorPages()
        .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler =  ReferenceHandler.Preserve;
            });
 */
        services
            .AddControllersWithViews()
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling =
                    ReferenceLoopHandling.Ignore;
            });
        services.AddCors(opt =>
            {
                opt
                    .AddDefaultPolicy(builder =>
                    {
                        builder
                            .WithOrigins("https://tmra.ai", "http://tmra.ai:5007", "http://localhost:5007")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .WithExposedHeaders("*");
                    });
            });
        if (_env.EnvironmentName == "Development" || 1 == 1)
        {
            services
                .AddSwaggerGen(c =>
                {
                    c
                        .SwaggerDoc("v1",
                        new OpenApiInfo { Title = "My API", Version = "v1" });
                    c.EnableAnnotations();
                });
            services
                .Configure<ServiceConfig>(config =>
                {
                    config.Services = new List<ServiceDescriptor>(services);
                    config.Path = "/listservices";
                });
        }
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Startup).Assembly));
        services
            .AddAuthentication("Bearer")
            .AddJwtBearer("Bearer",
                options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.Authority = appSettings.ConfigEndpoints.IdentityEndpointUrl;
                    options.MetadataAddress = $"{appSettings.ConfigEndpoints.IdentityEndpointUrl}/.well-known/openid-configuration";
                    options.Audience = "TPLClient_api_swaggerui";
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = false,
                        ValidIssuer = $"{appSettings.ConfigEndpoints.ValidIssuer}"
                    };
                }
            )
        ;
        services
        .AddAuthorization(options =>
        {
        });        
        
    }
    public void ConfigureContainer(ContainerBuilder builder)
    {
        builder.RegisterModule(new KnownAccountsCoreModule());
        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
           .Where(rs => rs.Name.StartsWith("SeedKnownAccount"))
        ;
        builder
            .RegisterModule(new KnownAccountsInfrastructureModule(_env
                    .EnvironmentName ==
                "Development"));
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      

        if (env.EnvironmentName == "Development")
        {
            app.UseDeveloperExceptionPage();
            app.UseShowAllServicesMiddleware();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        app.UseRouting();
        app.UseCors();
        app.UseAuthentication();
        app.UseAuthorization();
        // app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseCookiePolicy();
        app.UseSwagger();
        // Enable middleware to serve generated Swagger as a JSON endpoint.
        // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
        app
            .UseSwaggerUI(c =>
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
        app
            .UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
    }
}
