namespace Frenweh.UI.Common;
public class MenuItem
{
    public long Level { get; set; } = 0;
    public string Text { get; set; }
    public string Url { get; set; }
    public string UrlAutomaped { get; set; }
    public string Parent { get; set; }
    public string Icon { get; set; }
    public bool IsSeparator { get; set; }
    public List<MenuItem> Items = new();
}