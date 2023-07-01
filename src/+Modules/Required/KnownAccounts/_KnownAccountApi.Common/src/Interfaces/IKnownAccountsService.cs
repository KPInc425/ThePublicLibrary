namespace KnownAccountsApi.Common.Interfaces;
public interface IKnownAccountsService
{
    string ActiveModule { get; }
    void SetActiveModule(string module);
    event Action OnChange;    
}
