// ag=yes
namespace KnownAccountsApi.Common.Automaps; 
public partial class KnownAccountSubscriptionMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownAccountSubscriptionMap"; }
    }
    
    public KnownAccountSubscriptionMap()
    {
        CreateMap<KnownAccountSubscription, KnownAccountSubscriptionViewModel>()
        .ReverseMap();
    }
}