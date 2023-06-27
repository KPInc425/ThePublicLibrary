namespace YMI.YmiApplication.Shared.Configuration;
public class YmiAppSettings  { 
    public YmiFeatureFlags YmiFeatureFlags { get; set; } = new();
    public YmiEndpoints YmiEndpoints { get; set; } = new();
}
