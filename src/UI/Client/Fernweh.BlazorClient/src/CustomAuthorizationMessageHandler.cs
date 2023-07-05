namespace Fernweh.BlazorClient;
public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
{
    public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
        NavigationManager navigationManager)
        : base(provider, navigationManager)
    {
        ConfigureHandler(
            authorizedUrls: new[] {
                "http://localhost:44310",
                "http://localhost:5020/api",
                "http://localhost:5270/api",
                "http://localhost:5272/api",
                "http://localhost:5274/api",
                "http://localhost:5276/api",
                "http://localhost:5278/api",
                "http://localhost:5280/api",
                "http://localhost:5282/api",
                "http://localhost:5284/api",
                "http://localhost:5286/api",
                "http://localhost:5288/api",
                "http://localhost:5290/api",

                "http://fernweh.com:44310",
                "http://fernweh.com:5020/api",
                "http://fernweh.com:5270/api",
                "http://fernweh.com:5272/api",
                "http://fernweh.com:5274/api",
                "http://fernweh.com:5276/api",
                "http://fernweh.com:5278/api",
                "http://fernweh.com:5280/api",
                "http://fernweh.com:5282/api",
                "http://fernweh.com:5284/api",
                "http://fernweh.com:5286/api",
                "http://fernweh.com:5288/api",
                "http://fernweh.com:5290/api",
                

                 },
            scopes: new[] { "openid", "email", "profile", "roles", "mack", "address" });

    }
}
