// ag=no
namespace KnownAccountsApi.Common.Automaps; 
public partial class WebsitePageContentMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "WebsitePageContentMap"; }
    }
    
    public WebsitePageContentMap()
    {
        CreateMap<WebsitePageContent, WebsitePageContentViewModel>()
        //.ReverseMap()
        ;
    }
}