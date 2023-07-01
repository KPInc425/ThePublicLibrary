// ag=yes
namespace KnownAccountsApi.Common.ViewModels; 
public partial class KnownBusinessProfileViewModel : ViewModelBase<Guid>
{ 

     [MaxLength(101)]
     public string Name { get; set; } = String.Empty;
     public Guid KnownBusinessId { get; set; }
     public KnownBusinessViewModel KnownBusiness { get; set; }

} 
        