namespace TPL.KnownAccounts.Api;
public class SeedKnownAccountsDataTPLRoot : ISeedScript
{
    public async Task Initialize(IServiceProvider serviceProvider, IMediator mediator)
    {
        using (
            var dbContext =
                new KnownAccountsDbContext(
                    serviceProvider
                        .GetRequiredService<DbContextOptions<KnownAccountsDbContext>>(
                            ), mediator)
        )
        {
            await PopulateTestData(dbContext);
        }
    }

    public static readonly string ProgramModuleName = "TPL";
    public static readonly string UIKitModuleName = "uikit";
    public static readonly string KnownBusinessName = "TPL Root";
    public static readonly string KnownBusinessEmail = "TPLg@TPL.com";
    public static readonly string KnownBusinessDomain = "thepubliclibrary.ai";
    public static readonly Guid KnownAccountId = new Guid("a0002aaaaaaaaaaaaaaaa7f91b373b32");
    public KnownAccount? KnownAccount;
    public static readonly Guid KnownBusinessId = new Guid("a0102aaaaaaaaaaaaaaaa7f91b373b32");
    public KnownBusiness? KnownBusiness;
    public static readonly Guid KnownBusinessWebsiteId = new Guid("a001baaaaaaaaaaaaaaaa7f91b373b32");
    public KnownBusinessWebsite? KnownBusinessWebsite;

    public static readonly Guid KnownBusinessWebsiteAliasId = new Guid("eeeeeeaaaaaaaaaaaaaaa7f91b373b32");
    public KnownBusinessWebsiteAlias? KnownBusinessWebsiteAlias;

    public static readonly Guid KnownBusinessWebsiteLocalhostAliasId = new Guid("ddddddaaaaaaaaaaaaaaa7f91b373b32");
    public KnownBusinessWebsiteAlias? KnownBusinessWebsiteLocalhostAlias;

    public static readonly Guid KnownBusinessWebsiteProfileId = new Guid("a001baaaaaaaaaaaaaaaa7f91b373b32");
    public KnownBusinessWebsiteProfile? KnownBusinessWebsiteProfile;

    public static readonly Guid HomePageId = new Guid("a00bbaaaaaaaaaaaaaaaa7f91b373b32");
    public WebsitePage? HomePage;
    public static readonly Guid HostPageId = new Guid("a01bbaaaaaaaaaaaaaaaa7f91b373b32");
    public WebsitePage? HostPage;
    public static readonly Guid JoinPageId = new Guid("a02bbaaaaaaaaaaaaaaaa7f91b373b32");
    public WebsitePage? JoinPage;
    public static readonly Guid AboutPageId = new Guid("a04bbaaaaaaaaaaaaaaaa7f91b373b32");
    public WebsitePage? AboutPage;
    public static readonly Guid ContactPageId = new Guid("a05bbaaaaaaaaaaaaaaaa7f91b373b32");
    public WebsitePage? ContactPage;
    public static readonly Guid LandingPageId = new Guid("a06bbaaaaaaaaaaaaaaaa7f91b373b32");
    public WebsitePage? LandingPage;

    public async Task PopulateTestData(KnownAccountsDbContext dbContext)
    {
        var existing = dbContext.KnownAccounts.Find(KnownAccountId);
        if (existing == null)
        {
            KnownAccount =
                new KnownAccount(KnownAccountId, KnownBusinessName, KnownBusinessEmail);
            KnownAccount.AddKnownAccountProfile(KnownBusinessName);
            dbContext.KnownAccounts.Add(KnownAccount);
        }

        KnownBusiness = dbContext.KnownBusinesses.FirstOrDefault(rs => rs.Name == KnownBusinessName);

        if (KnownBusiness == null)
        {
            KnownBusiness = new KnownBusiness(KnownBusinessName);

            KnownBusinessWebsite =
                new KnownBusinessWebsite(KnownBusinessWebsiteId, KnownBusiness, KnownBusinessDomain, KnownBusinessDomain);

            KnownBusinessWebsite.AddKnownBusinessWebsiteAlias(new KnownBusinessWebsiteAlias(KnownBusinessWebsite, "local.thepubliclibrary.ai", "local.thepubliclibrary.ai"));
            KnownBusinessWebsite.AddKnownBusinessWebsiteAlias(new KnownBusinessWebsiteAlias(KnownBusinessWebsite, "localhost", "localhost"));
            KnownBusinessWebsite.AddKnownBusinessWebsiteAlias(new KnownBusinessWebsiteAlias(KnownBusinessWebsite, "game.thepubliclibrary.ai", "game.thepubliclibrary.ai"));

            KnownBusinessWebsiteProfile =
                new KnownBusinessWebsiteProfile(KnownBusinessWebsiteProfileId, KnownBusinessWebsite, $"/Purchase", $"/Welcome", "/TPLLogo.svg");

            KnownBusinessWebsite.SetKnownBusinessWebsiteProfile(KnownBusinessWebsiteProfile);

            HostPage = new WebsitePage(HostPageId, KnownBusinessWebsite, $"/{ProgramModuleName}/Host", "Host", true, true, "ConnectWithoutContact", "Host");
            KnownBusinessWebsite.AddWebsitePage(HostPage);

            JoinPage = new WebsitePage(JoinPageId, KnownBusinessWebsite, $"/{ProgramModuleName}/Join", "Join", true, true, "EmojiPeople", "Join");
            KnownBusinessWebsite.AddWebsitePage(JoinPage);

            ContactPage = new WebsitePage(ContactPageId, KnownBusinessWebsite, $"/Contact", "Contact", true, true, "SupportAgent", "Contact");
            KnownBusinessWebsite.AddWebsitePage(ContactPage);

            AboutPage = new WebsitePage(AboutPageId, KnownBusinessWebsite, $"/About", "About", true, false, "QuestionMark", "About");
            AboutPage.SetWebsitePageContent("<div>About us!</div>");
            KnownBusinessWebsite.AddWebsitePage(AboutPage);

            LandingPage = new WebsitePage(LandingPageId, KnownBusinessWebsite, $"/{ProgramModuleName}/Landing", "Landing", false, true, "abc", "Landing");
            KnownBusinessWebsite.AddWebsitePage(LandingPage);

            KnownBusiness.AddKnownBusinessWebsite(KnownBusinessWebsite);
            dbContext.KnownBusinesses.Add(KnownBusiness);
            await dbContext.SaveChangesAsync();
        }
    }
}
