// ag=yes
namespace AccountModuleCore..Api.Common.Automaps; 
public partial class KnownAccountSubscriptionMap : Profile
{ 
    public override string ProfileName => "KnownAccountSubscriptionMap";
    
    public KnownAccountSubscriptionMap()
    {
        CreateMap<KnownAccountSubscription, KnownAccountSubscriptionViewModel>()
        .ReverseMap();
    }
}