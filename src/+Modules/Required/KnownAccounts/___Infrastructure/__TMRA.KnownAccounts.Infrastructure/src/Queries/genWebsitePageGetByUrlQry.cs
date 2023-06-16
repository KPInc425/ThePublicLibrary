// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Queries; 
public partial class WebsitePageGetByUrlQry : IRequest<KnownBusinessWebsite>
{
    [Required]
    public string Url { get; set; }
    private WebsitePageGetByUrlQry() { }
    public WebsitePageGetByUrlQry(string url)
    {
        Url = url;
    }
}
