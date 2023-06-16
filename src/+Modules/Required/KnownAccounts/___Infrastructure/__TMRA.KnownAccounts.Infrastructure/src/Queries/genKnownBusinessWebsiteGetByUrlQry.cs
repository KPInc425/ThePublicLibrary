// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Queries; 
public partial class KnownBusinessWebsiteGetByUrlQry : IRequest<KnownBusinessWebsite>
{
    public KnownBusinessWebsiteGetByUrlQry(string url) {
        Url = Guard.Against.NullOrEmpty(url);
    }
    public string Url {get;set;}
}
