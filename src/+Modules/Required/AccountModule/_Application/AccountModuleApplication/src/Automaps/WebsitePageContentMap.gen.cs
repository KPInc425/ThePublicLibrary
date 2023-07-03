// ag=yes
namespace AccountModuleCore..Api.Common.Automaps; 
public partial class WebsitePageContentMap : Profile
{ 
    public override string ProfileName => "WebsitePageContentMap";
    
    public WebsitePageContentMap()
    {
        CreateMap<WebsitePageContent, WebsitePageContentViewModel>()
        .ReverseMap();
    }
}