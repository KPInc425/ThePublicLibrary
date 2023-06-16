// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Commands; 
public partial class WebsitePageUpdateCmd : IRequest<KnownBusinessWebsite>
{
    private WebsitePageUpdateCmd() { }
    public WebsitePageUpdateCmd(WebsitePage websitePage)
    {
        WebsitePage = websitePage;
    }
    public WebsitePage WebsitePage { get; set; }
}
