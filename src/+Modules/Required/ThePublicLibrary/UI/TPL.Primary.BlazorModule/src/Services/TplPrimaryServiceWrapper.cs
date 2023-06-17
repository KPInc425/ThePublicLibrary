namespace TPL.Primary.BlazorModule;
public class TplPrimaryServiceWrapper
{
    public IDataService _tplPrimaryService;
    public IDataService IDataService { get => _tplPrimaryService; set { _tplPrimaryService = value; } }
}