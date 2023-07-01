namespace Fernweh.Common.Services;
public class PlatformCacheService
{
    private ITplDataService _dataService;
    
    public PlatformCacheService(ITplDataService dataService)
    {
        _dataService = dataService;
    }
    public bool HasInitRun { get; set; } = false;
    public bool IsOwner { get; private set; } = false;
    public bool IsCoHost { get; private set; } = false;

    private bool _userDataIsReady = true; // false;
    private bool _businessDataIsReady = true; // false;
    private bool _appDataIsReady = true; // false;
    
    private string _currentModule = "";
    private string _currentSubModule = "";
    
    public event Action? OnChange;
    public event Action? OnRoomChange;
    public event Action? OnMenuChange;
    public event Action? OnSkinChange;
    
    private void NotifyStateChanged() => OnChange?.Invoke();
    private void NotifyOnMenuChange() => OnMenuChange?.Invoke();
    private void NotifyOnRoomChange() => OnRoomChange?.Invoke();
    private void NotifyOnSkinChange() => OnSkinChange?.Invoke();
    
    public bool UserDataIsReady
    {
        get => _userDataIsReady;
    }
    public bool AppDataIsReady
    {
        get => _appDataIsReady;
    }
    public bool BusinessDataIsReady
    {
        get => _businessDataIsReady;
    }
    public void ResetMenuData()
    {
    }

    public async Task InitAppDataAsync(bool isAuthenticated)
    {
        if (isAuthenticated)
        {
            // get authorized user data
        }
        else if (!isAuthenticated)
        {
            // get anonymous user data
        }

        SetAppDataToReady();
        
        await Task.Yield();
    }
    public void UpdateMenu()
    {
        NotifyOnMenuChange();
    }

    public void UpdateSkin()
    {
        NotifyOnSkinChange();
    }
    public bool AllIsInit
    {
        get => _appDataIsReady && _userDataIsReady;
    }
    private void SetUserDataToReady(bool value = true)
    {
        _userDataIsReady = value;
        NotifyStateChanged();
    }
    private void SetBusinessDataToReady(bool value = true)
    {
        _businessDataIsReady = value;
        NotifyStateChanged();
    }
    private void SetAppDataToReady(bool value = true)
    {
        _appDataIsReady = value;
        NotifyStateChanged();
        NotifyOnMenuChange();
    }
    
    /* public void SetKnownBusinessWebsiteProfile(KnownBusinessWebsiteProfileViewModel knownBusinessWebsiteProfile)
    {
        KnownBusinessWebsite.KnownBusinessWebsiteProfile = knownBusinessWebsiteProfile;
        NotifyStateChanged();
    } */

    public string CurrentModule => _currentModule;
    public string CurrentSubModule => _currentSubModule;
    public void SetCurrentModule(string module)
    {
        this._currentModule = module;
    }
    public void SetCurrentSubModule(string subModule)
    {
        this._currentSubModule = subModule;
    }
}
