namespace TPL.KnownAccounts.Api.Common.Interfaces;
public interface IKnownAccountsService
{
    string ActiveModule { get; }
    void SetActiveModule(string module);
    event Action OnChange;    
}
