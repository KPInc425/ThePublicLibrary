// ag=no
namespace TPL.KnownAccounts.Api.Common.Automaps; 
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