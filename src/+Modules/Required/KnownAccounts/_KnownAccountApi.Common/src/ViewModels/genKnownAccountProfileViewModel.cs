// ag=yes
namespace KnownAccountsApi.Common.ViewModels; 
public partial class KnownAccountProfileViewModel : ViewModelBase<Guid>
{ 

     public Guid KnownAccountId { get; set; }
     public KnownAccountViewModel KnownAccount { get; set; }
     [MaxLength(101)]
     public string Name { get; set; } = String.Empty;

} 
        