// ag=yes
namespace KnownAccountsApi.Common.Automaps; 
public partial class ValidSubscriptionMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "ValidSubscriptionMap"; }
    }
    
    public ValidSubscriptionMap()
    {
        CreateMap<ValidSubscription, ValidSubscriptionViewModel>()
        .ReverseMap();
    }
}