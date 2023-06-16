namespace TPL.UI.Common.Models
{
    public class MudSelectItemModel
    {
        public string Value { get; set; }
        public string AdornmentIcon { get; set; }
        public string Style { get; set; }
        public string Tag { get; set; }
        public bool IsSelected { get; set; } = false;
        public string ValidPrefix { get; set; } = "";
    }
}