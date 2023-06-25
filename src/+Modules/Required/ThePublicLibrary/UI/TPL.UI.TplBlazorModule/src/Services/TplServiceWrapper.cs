namespace TPL.UI.TplBlazorModule;
public class TplServiceWrapper
{
    public ITplDataService _tplService;
    public ITplDataService ITplDataService { get => _tplService; set { _tplService = value; } }
}