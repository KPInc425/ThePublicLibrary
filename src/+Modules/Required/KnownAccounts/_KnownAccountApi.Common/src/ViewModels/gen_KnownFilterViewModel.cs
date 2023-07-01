// ag=yes
namespace KnownAccountsApi.Common.ViewModels; 
public partial class KnownFilterViewModel : ViewModelBase<Guid>
{ 

     public string Name { get; set; } = "";
     public bool IsActive { get; set; } = true;

} 
        