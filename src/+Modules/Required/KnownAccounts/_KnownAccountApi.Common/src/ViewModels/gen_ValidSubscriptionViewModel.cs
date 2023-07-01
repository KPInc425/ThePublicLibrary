// ag=yes
namespace KnownAccountsApi.Common.ViewModels; 
public partial class ValidSubscriptionViewModel : ViewModelBase<Guid>
{ 

     [MaxLength(100)]
     public string Name { get; set; } ="";
     public bool IsActive { get; set; } = true;

} 
        