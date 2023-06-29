namespace Fernweh.UI.BlazorClient.UIUnitTests;
public class BaseTest
{
    protected TestContext ctx = new TestContext();

    public BaseTest()
    {
        var mockHttpClient = Mock.Create<HttpClient>();
        var mockPlatformStateCacheService = Mock.Create<PlatformStateCacheService>();
        var mockPlatformCacheService = Mock.Create<PlatformCacheService>();
        var mockILayoutService = Mock.Create<ILayoutService>();
        var mockBrowserResizeService = Mock.Create<BrowserResizeService>();
        var mockRandomizerService = Mock.Create<RandomizerService>();
        var mockLazyModuleJsInterop = Mock.Create<LazyModuleJsInterop>();
        var mockEndpoints = Mock.Create<Endpoints>();
        var mockFeatureFlags = Mock.Create<FeatureFlags>();
        var mockAppSettings = Mock.Create<AppSettings>();
        var mockNavigationManager = Mock.Create<NavigationManager>();
        
        var mockIStringLocalizer = Mock.Create<IStringLocalizer>();
        var mockLocalizeShared = Mock.Create<IStringLocalizer<SharedLanguageBase>>();

        // ThePublicLibrary
        var mockITplDataService = Mock.Create<ITplDataService>();
        ctx.Services.AddSingleton<ITplDataService>(mockITplDataService);
        
        var mockTplHttpClientFactory = Mock.Create<TplHttpClientFactory>();        
        ctx.Services.AddSingleton<TplHttpClientFactory>(mockTplHttpClientFactory);
        // \ThePublicLibrary

        // YourMainIdea        
        var mockIYmiDataService = Mock.Create<IYmiDataService>();
        ctx.Services.AddSingleton<IYmiDataService>(mockIYmiDataService);
        
        var mockYmiHttpClientFactory = Mock.Create<YmiHttpClientFactory>();
        ctx.Services.AddSingleton<YmiHttpClientFactory>(mockYmiHttpClientFactory);
        // \YourMainIdea

        
        
        ctx.Services.AddSingleton<HttpClient>(mockHttpClient);
        ctx.Services.AddSingleton<PlatformStateCacheService>(mockPlatformStateCacheService);
        ctx.Services.AddSingleton<PlatformCacheService>(mockPlatformCacheService);
        ctx.Services.AddSingleton<ILayoutService>(mockILayoutService);
        ctx.Services.AddSingleton<BrowserResizeService>(mockBrowserResizeService);
        ctx.Services.AddSingleton<RandomizerService>(mockRandomizerService);
        ctx.Services.AddSingleton<LazyModuleJsInterop>(mockLazyModuleJsInterop);
        ctx.Services.AddSingleton<Endpoints>(mockEndpoints);
        ctx.Services.AddSingleton<FeatureFlags>(mockFeatureFlags);
        ctx.Services.AddSingleton<AppSettings>(mockAppSettings);
        ctx.Services.AddSingleton<NavigationManager>(mockNavigationManager);
        ctx.Services.AddSingleton<IStringLocalizer>(mockIStringLocalizer);
        ctx.Services.AddSingleton<IStringLocalizer<SharedLanguageBase>>(mockLocalizeShared);

        ctx.Services.AddSingleton<LazyAssemblyLoader>();

    }
}