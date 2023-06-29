namespace YMI.YmiApplication.Shared.ViewModels;
public class DigitalAddyVOViewModel
{
    public DigitalAddyType Type { get; set; } = DigitalAddyType.NotSet;
    public string Value { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
