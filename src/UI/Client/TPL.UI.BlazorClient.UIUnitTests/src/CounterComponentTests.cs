namespace TPL.UI.BlazorClient.UIUnitTests;

public class CounterComponentTests
{
    [Fact]
    public void CounterComponentTest()
    {
        // Arrange some stuff, move it out later

        var mockIDataService = Mock.Create<IDataService>();
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
        var mockTplPrimaryHttpClientFactory = Mock.Create<TplPrimaryHttpClientFactory>();        

        var mockJsInterop = Mock.Create<IJSRuntime>(new ());
        var mockIStringLocalizer = Mock.Create<IStringLocalizer>();
        var mockLocalizeShared = Mock.Create<IStringLocalizer<SharedLanguageBase>>();
        

        // Given I have a counter component
        using var ctx = new TestContext();
        ctx.Services.AddSingleton<IDataService>(mockIDataService);
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
        ctx.Services.AddSingleton<TplPrimaryHttpClientFactory>(mockTplPrimaryHttpClientFactory);        
        ctx.Services.AddSingleton<IStringLocalizer>(mockIStringLocalizer);
        ctx.Services.AddSingleton<IStringLocalizer<SharedLanguageBase>>(mockLocalizeShared);        
        ctx.Services.AddSingleton<LazyAssemblyLoader>(new LazyAssemblyLoader());
        ctx.Services.AddSingleton<IJSRuntime>(mockJsInterop);

        var component = ctx.RenderComponent<Counter>();        

        /* var mockIDataService = Mock.Create<IDataService>();
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
        var mockTplPrimaryHttpClient = Mock.Create<HttpClient>();
        var mockJsInterop = Mock.Create<IJSRuntime>(); */


        // And the counter is initialized to 0
        component.Find("#currentCount").TextContent.Should().Be("0");

        // When I increment the count
        component.Find("#incrementPlus").Click();

        // The count should be 1
        component.Find("#currentCount").TextContent.Should().Be("1");

    }
}